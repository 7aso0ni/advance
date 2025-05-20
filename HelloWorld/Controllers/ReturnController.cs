using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rental.Controllers;

public class ReturnController : BaseController
{
    public ReturnController(DBContext context) : base(context) { }

    // Admin/Manager View: Show All Requests Due for Return
    public async Task<IActionResult> Manage(int? status, string? search)
    {
        ViewBag.Users = await _context.Users.ToListAsync();
        ViewBag.EquipmentList = await _context.Equipment.ToListAsync();

        var user = GetUserObject();
        if (user == null || (user.RoleId != 1 && user.RoleId != 2))
            return Unauthorized();

        var rentalReturns = await _context.RentalRequests
            .Include(r => r.User)
            .Include(r => r.Equipment)
            .Include(r => r.RentalStatus1)
            .Include(r => r.Transaction)
            .Where(r =>
                _context.ReturnRecords.Any(rr => rr.Equipment == r.EquipmentId) &&
                r.Transaction != null &&
                r.Transaction.PaymentStatus == 2
            )
            .ToListAsync();

        if (status.HasValue && status.Value != 0)
            rentalReturns = rentalReturns.Where(r => r.RentalStatus == status.Value).ToList();

        if (!string.IsNullOrEmpty(search))
            rentalReturns = rentalReturns.Where(r =>
                (r.Equipment?.Name?.ToLower().Contains(search.ToLower()) ?? false) ||
                (r.User?.Fname?.ToLower().Contains(search.ToLower()) ?? false) ||
                (r.User?.Lname?.ToLower().Contains(search.ToLower()) ?? false)
            ).ToList();

        ViewBag.Conditions = await _context.ConditionStatuses.ToListAsync();
        ViewBag.ReturnRecords = await _context.ReturnRecords.ToListAsync();
        ViewBag.SelectedStatus = status;
        ViewBag.Search = search;

        return View(rentalReturns);
    }




    // Customer View: See their returns
    public async Task<IActionResult> MyReturns()
    {
        var user = GetUserObject();
        if (user == null) return RedirectToAction("Index", "SignIn");

        var returnRecords = await _context.ReturnRecords
            .Include(r => r.EquipmentNavigation)
            .Include(r => r.ConditionNavigation)
            .Join(_context.RentalRequests,
                rr => rr.Equipment,
                rq => rq.EquipmentId,
                (rr, rq) => new { Return = rr, Request = rq })
            .Where(joined => joined.Request.UserId == user.Id)
            .Select(joined => joined.Return)
            .ToListAsync();

        return View(returnRecords);
    }



    [HttpPost]
    public async Task<IActionResult> MarkReturned(int id, int conditionId)
    {
        var rental = await _context.RentalRequests
            .Include(r => r.Transaction)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (rental == null || rental.Transaction == null || rental.Transaction.PaymentStatus != 2)
            return BadRequest("Transaction not found or not paid.");

        var returnRecord = new ReturnRecord
        {
            Equipment = rental.EquipmentId,
            ReturnDate = DateTime.Now,
            Condition = conditionId,
            LateFees = 0
        };

        rental.RentalStatus = 6; // Returned

        _context.ReturnRecords.Add(returnRecord);
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = "Marked as Returned.";
        return RedirectToAction("Manage");
    }

    [HttpPost]
    public async Task<IActionResult> MarkOverdue(int id, int conditionId, decimal lateFee)
    {
        var rental = await _context.RentalRequests
            .Include(r => r.Transaction)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (rental == null || rental.Transaction == null || rental.Transaction.PaymentStatus != 2)
            return BadRequest("Transaction not found or not paid.");

        var returnRecord = new ReturnRecord
        {
            Equipment = rental.EquipmentId,
            ReturnDate = DateTime.Now,
            Condition = conditionId,
            LateFees = lateFee
        };

        rental.RentalStatus = 7; // Overdue

        _context.ReturnRecords.Add(returnRecord);
        await _context.SaveChangesAsync();

        TempData["ErrorMessage"] = "Marked as Overdue with late fee.";
        return RedirectToAction("Manage");
    }
    [HttpPost]
    public async Task<IActionResult> Unmark(int id)
    {
        var rental = await _context.RentalRequests
            .Include(r => r.Transaction)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (rental == null || rental.Transaction == null)
            return NotFound("Rental request not found.");

        // Find the return record by equipment ID
        var returnRecord = await _context.ReturnRecords
            .FirstOrDefaultAsync(r => r.Equipment == rental.EquipmentId);

        if (returnRecord != null)
        {
            _context.ReturnRecords.Remove(returnRecord);
            rental.RentalStatus = 5; // Reset status to Active (or whatever appropriate)
            await _context.SaveChangesAsync();
        }

        TempData["SuccessMessage"] = "Return record unmarked successfully.";
        return RedirectToAction("Manage");
    }
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        ViewBag.Users = await _context.Users.ToListAsync();
        ViewBag.EquipmentList = await _context.Equipment.ToListAsync();
        ViewBag.ConditionList = await _context.ConditionStatuses.ToListAsync();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(int userId, int equipmentId, int conditionId, DateTime returnDate, decimal lateFee)
    {
        var returnRecord = new ReturnRecord
        {
            Equipment = equipmentId,
            Condition = conditionId,
            ReturnDate = returnDate,
            LateFees = lateFee
        };

        _context.ReturnRecords.Add(returnRecord);

        // Update related RentalRequest
        var rental = await _context.RentalRequests
            .Where(r => r.EquipmentId == equipmentId && r.UserId == userId)
            .OrderByDescending(r => r.ReturnDate)
            .FirstOrDefaultAsync();

        if (rental != null)
        {
            rental.RentalStatus = lateFee > 0 ? 7 : 6; // 7 = Overdue, 6 = Returned
        }

        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = "Return record added successfully.";
        return RedirectToAction("Manage");
    }

    [HttpPost]
    public async Task<IActionResult> AddManualReturn(int userId, int equipmentId, int conditionId, decimal? lateFee)
    {
        var request = await _context.RentalRequests
            .Include(r => r.Transaction)
            .FirstOrDefaultAsync(r =>
                r.UserId == userId &&
                r.EquipmentId == equipmentId &&
                r.Transaction != null &&
                r.Transaction.PaymentStatus == 2); // Paid

        if (request == null)
        {
            TempData["ErrorMessage"] = "No matching paid rental found for this user and equipment.";
            return RedirectToAction("Manage");
        }

        var record = new ReturnRecord
        {
            Equipment = equipmentId,
            Condition = conditionId,
            ReturnDate = DateTime.Now,
            LateFees = lateFee ?? 0
        };

        request.RentalStatus = lateFee > 0 ? 7 : 6; // Overdue or Returned

        _context.ReturnRecords.Add(record);
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = "Return record added successfully.";
        return RedirectToAction("Manage");
    }


}
