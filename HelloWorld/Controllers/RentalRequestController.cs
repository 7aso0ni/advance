using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    public class RentalRequestController : BaseController
    {
        public RentalRequestController(DBContext context) : base(context) { }

        [HttpGet]
        public IActionResult Index(string search, int? status)
        {
            int? userId = GetUserObject()?.Id;
            if (userId == null)
            {
                TempData["ErrorMessage"] = "You must be logged in.";
                return RedirectToAction("Index", "SignIn");
            }

            var rentalHistory = _context.RentalRequests
                .Where(r => r.UserId == userId)
                .Include(r => r.Equipment)
                .Include(r => r.RentalStatus1)
                .Include(r => r.Transaction)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                rentalHistory = rentalHistory.Where(r =>
                    r.Equipment.Name.Contains(search));
            }

            if (status.HasValue && status != 0)
            {
                rentalHistory = rentalHistory.Where(r => r.RentalStatus == status);
            }

            ViewBag.Search = search;
            ViewBag.Status = status;

            return View(rentalHistory.ToList());
        }

        public async Task<IActionResult> CreateRequestFromDetails(int equipmentId)
        {
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "Please log in.";
                return RedirectToAction("Index", "SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment == null)
            {
                TempData["ErrorMessage"] = "Equipment not found.";
                return RedirectToAction("Index", "Equipment");
            }

            var request = new RentalRequest
            {
                EquipmentId = equipment.Id,
                UserId = user.Id,
                StartDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7),
                Cost = equipment.Price * 7,
                RentalStatus = 1 // Pending
            };

            try
            {
                await _context.RentalRequests.AddAsync(request);
                await _context.SaveChangesAsync();

                // ✅ Save log
                await SaveLogAsync("Create Rental Request", $"Request created for Equipment: {equipment.Name}", "Web");

                TempData["SuccessMessage"] = "Rental request created and is now pending approval.";
                return RedirectToAction("Index"); // Go to My Requests page
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorMessage"] = $"Error creating rental request: {ex.InnerException?.Message ?? ex.Message}";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create(int equipmentId)
        {
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "Please log in first.";
                return RedirectToAction("Index", "SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(equipmentId);
            if (equipment == null)
            {
                TempData["ErrorMessage"] = "Equipment not found.";
                return RedirectToAction("Index", "Equipment");
            }

            var request = new RentalRequest
            {
                EquipmentId = equipment.Id,
                UserId = user.Id,
                StartDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7),
                Cost = equipment.Price * 7,
                RentalStatus = 1 // Pending
            };

            try
            {
                await _context.RentalRequests.AddAsync(request);
                await _context.SaveChangesAsync();

                // ✅ Log action
                await SaveLogAsync("Create Rental Request", $"Request created for EquipmentID: {equipment.Id}", "Web");

                TempData["SuccessMessage"] = "Rental request submitted successfully!";
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorMessage"] = $"Error creating rental request: {ex.InnerException?.Message ?? ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 2; // Approved
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Approve Rental Request", $"RequestID: {requestId} approved", "Web");

            TempData["SuccessMessage"] = "Rental request approved successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Reject(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 3; // Rejected
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Reject Rental Request", $"RequestID: {requestId} rejected", "Web");

            TempData["ErrorMessage"] = "Rental request has been rejected.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Complete(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null) return NotFound("Rental request not found.");

            request.RentalStatus = 8; // Completed
            await _context.SaveChangesAsync();

            // ✅ Log action
            await SaveLogAsync("Complete Rental", $"Rental completed for RequestID: {requestId}", "Web");

            TempData["SuccessMessage"] = "Rental marked as completed!";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Payment(int requestId)
        {
            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == requestId);

            if (rentalRequest == null)
            {
                TempData["ErrorMessage"] = "Rental request not found.";
                return RedirectToAction("Index");
            }

            ViewBag.RentalRequest = rentalRequest;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmPayment(int requestId)
        {
            var rentalRequest = await _context.RentalRequests.FindAsync(requestId);
            if (rentalRequest == null)
            {
                TempData["ErrorMessage"] = "Rental request not found.";
                return RedirectToAction("Index");
            }

            // Update status to Completed (Paid)
            rentalRequest.RentalStatus = 8;
            await _context.SaveChangesAsync();

            await SaveLogAsync("Payment Completed", $"Rental request {requestId} marked as paid.", "Web");

            TempData["SuccessMessage"] = "Payment successful!";
            return RedirectToAction("Index");
        }


    
        // Show all users' rental requests for Admin
        public async Task<IActionResult> UserRequests()
        {
            var requests = await _context.RentalRequests
                .Include(r => r.User)
                .Include(r => r.Equipment)
                .Include(r => r.RentalStatus1)
                .ToListAsync();

            return View(requests);
        }


        [HttpPost]
        public async Task<IActionResult> AdminApprove(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null)
            {
                return NotFound();
            }

            request.RentalStatus = 2; // Approved
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Request approved successfully.";
            return RedirectToAction("UserRequests");
        }

        [HttpPost]
        public async Task<IActionResult> AdminReject(int requestId)
        {
            var request = await _context.RentalRequests.FindAsync(requestId);
            if (request == null)
            {
                return NotFound();
            }

            request.RentalStatus = 3; // Rejected
            await _context.SaveChangesAsync();

            TempData["ErrorMessage"] = "Request rejected.";
            return RedirectToAction("UserRequests");
        }
        [HttpGet]
        public async Task<IActionResult> StartTransaction(int requestId)
        {
            var request = await _context.RentalRequests
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == requestId);

            if (request == null)
            {
                return NotFound("Rental request not found.");
            }

            ViewBag.RequestId = requestId;
            ViewBag.Equipment = request.Equipment;

            return View(); // This will look for Views/RentalRequest/StartTransaction.cshtml
        }


        // --- Controller Method ---

        [HttpPost]
        public async Task<IActionResult> SaveTransaction(
           int requestId,
           DateTime pickup,
           DateTime returnDate,
           IFormFile idProof)
        {
            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == requestId);

            if (rentalRequest == null)
                return NotFound("Rental request not found.");

            var user = GetUserObject();
            if (user == null)
                return Unauthorized();

            // Validate dates
            if (pickup < DateTime.Today)
            {
                TempData["ErrorMessage"] = "Pickup date must be today or later.";
                return RedirectToAction("StartTransaction", new { requestId });
            }
            if (returnDate <= pickup)
            {
                TempData["ErrorMessage"] = "Return date must be after pickup date.";
                return RedirectToAction("StartTransaction", new { requestId });
            }

            // Calculate pricing
            var period = (decimal)(returnDate - pickup).TotalDays;
            var pricePerDay = rentalRequest.Equipment.Price;
            var fee = pricePerDay * period;
            var deposit = pricePerDay;

            // Save transaction
            var transaction = new RentalTransaction
            {
                RentalStatus = 5, // Active
                UserId = user.Id,
                Pickup = pickup,
                ReturnDate = returnDate,
                Period = period,
                Fee = fee,
                Deposit = deposit,
                PaymentStatus = 1 // Unpaid
            };

            _context.RentalTransactions.Add(transaction);
            await _context.SaveChangesAsync();

            // Link transaction to rental request
            rentalRequest.RentalTransactionId = transaction.Id;
            await _context.SaveChangesAsync();

            // ✅ Save ID Proof Document if uploaded
            if (idProof != null && idProof.Length > 0)
            {
                var uploadsDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "documents");
                Directory.CreateDirectory(uploadsDir);

                var uniqueFileName = $"{Guid.NewGuid()}_{Path.GetFileName(idProof.FileName)}";
                var filePath = Path.Combine(uploadsDir, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await idProof.CopyToAsync(stream);
                }

                // Store relative path as byte[]
                var relativePath = Path.Combine("uploads", "documents", uniqueFileName);
                var pathBytes = System.Text.Encoding.UTF8.GetBytes(relativePath);

                if (pathBytes.Length > 50)
                    pathBytes = pathBytes.Take(50).ToArray(); // truncate to fit column size

                var document = new Document
                {
                    UserId = user.Id,
                    FileName = idProof.FileName,
                    FileType = idProof.ContentType,
                    UploadeDate = DateTime.Now,
                    StoragePath = pathBytes,
                    DocumentType = 4 // ID Proof
                };

                _context.Documents.Add(document);
                await _context.SaveChangesAsync();
            }

            TempData["SuccessMessage"] = "Transaction and ID Proof saved successfully!";
            return RedirectToAction("Index");
        }



        [HttpGet]
        public async Task<IActionResult> PayTransaction(int transactionId)
        {
            var transaction = await _context.RentalTransactions
                .Include(t => t.User)
                .Include(t => t.RentalStatusNavigation)
                .FirstOrDefaultAsync(t => t.Id == transactionId);

            if (transaction == null)
                return NotFound("Transaction not found.");

            ViewBag.Transaction = transaction;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PayTransactionConfirmed(int transactionId)
        {
            var transaction = await _context.RentalTransactions.FindAsync(transactionId);
            if (transaction == null)
                return NotFound("Transaction not found.");

            transaction.PaymentStatus = 2; // Mark as paid
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Payment successful!";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateByAdmin()
        {
            ViewBag.Users = _context.Users.ToList();
            ViewBag.Equipment = _context.Equipment.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateByAdmin([Bind("UserId,EquipmentId,StartDate,ReturnDate,Cost")] RentalRequest request)
        {
            request.RentalStatus = 1; // Pending

            try
            {
                _context.RentalRequests.Add(request);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Rental request created successfully.";
                return RedirectToAction("UserRequests");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while saving the rental request.";
                ViewBag.Users = _context.Users.ToList();
                ViewBag.Equipment = _context.Equipment.ToList();
                return View(request);
            }
        }





    }
}
