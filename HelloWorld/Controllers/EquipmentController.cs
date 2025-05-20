using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Persistence;
using ClassLibrary.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    public class EquipmentController : BaseController
    {
        private static bool _showFeedback = true;
        public EquipmentController(DBContext context) : base(context) { }

        public async Task<IActionResult> Index(int? categoryId)
        {
            if (!IsAuthenticated())
            {
                ViewBag.IsAuthenticated = false;
                return Redirect("/SignIn");
            }

            ViewBag.IsAuthenticated = true;

            try
            {
                var equipmentQuery = _context.Equipment.AsQueryable();

                if (categoryId.HasValue && categoryId.Value > 0)
                {
                    equipmentQuery = equipmentQuery.Where(e => e.CategoryId == categoryId.Value);
                }

                var equipmentList = await equipmentQuery
                    .Select(e => new
                    {
                        e.Id,
                        e.Name,
                        e.Description,
                        e.CategoryId,
                        e.Price,
                        e.AvailableId,
                        e.ConditionId,
                        ImageUrl = e.Image != null ? Convert.ToBase64String(e.Image) : null,
                        CategoryName = e.Category.Name
                    })
                    .ToListAsync();

                ViewBag.EquipmentList = equipmentList;
                ViewBag.Categories = await _context.Categories.ToListAsync();
                ViewBag.ConditionStatuses = await _context.ConditionStatuses.ToListAsync();
                ViewBag.AvailabilityStatuses = await _context.AvailableStatuses.ToListAsync();

                var user = GetUserObject();
                ViewBag.User = user;
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEquipment(string name, string description, int categoryId, decimal price, int availableId, int conditionId, IFormFile image)
        {
            if (!IsAuthenticated())
            {
                return Redirect("/SignIn");
            }

            // Get the user object first to ensure it's not null
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "User session expired. Please sign in again.";
                return Redirect("/SignIn");
            }

            byte[]? imageData = null;

            if (image != null && image.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await image.CopyToAsync(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }

            var newEquipment = new Equipment
            {
                Name = name,
                Description = description,
                CategoryId = categoryId,
                Price = price,
                AvailableId = availableId,
                ConditionId = conditionId,
                Image = imageData
            };

            _context.Equipment.Add(newEquipment);
            await _context.SaveChangesAsync();

            // ✅ Save Log
            await SaveLogAsync("Add Equipment", $"Name: {newEquipment.Name}", "Web");
            
            // Add notification for equipment addition
            await SaveNotificationAsync("Equipment Added", $"New equipment '{newEquipment.Name}' was added.", 1);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEquipment(int id)
        {
            if (!IsAuthenticated())
            {
                return Redirect("/SignIn");
            }

            var equipment = await _context.Equipment
                .Include(e => e.FeedBacks)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (equipment == null)
            {
                return NotFound();
            }

            var hasRentalRequests = _context.RentalRequests.Any(r => r.EquipmentId == id);
            if (hasRentalRequests)
            {
                TempData["ErrorMessage"] = "Cannot delete equipment. It has related rental requests.";
                return RedirectToAction("Index");
            }

            if (equipment.FeedBacks.Any())
            {
                _context.FeedBacks.RemoveRange(equipment.FeedBacks);
            }

            _context.Equipment.Remove(equipment);
            await _context.SaveChangesAsync();

            // ✅ Save Log
            await SaveLogAsync("Delete Equipment", $"Name: {equipment.Name}", "Web");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditEquipment(int id)
        {
            if (!IsAuthenticated())
            {
                return Redirect("/SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }

            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.ConditionStatuses = await _context.ConditionStatuses.ToListAsync();
            ViewBag.AvailabilityStatuses = await _context.AvailableStatuses.ToListAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditEquipment(int id, string name, string description, int categoryId, decimal price, int availableId, int conditionId, IFormFile? image)
        {
            if (!IsAuthenticated())
            {
                return Redirect("/SignIn");
            }

            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }

            equipment.Name = name;
            equipment.Description = description;
            equipment.CategoryId = categoryId;
            equipment.Price = price;
            equipment.AvailableId = availableId;
            equipment.ConditionId = conditionId;

            if (image != null && image.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await image.CopyToAsync(memoryStream);
                    equipment.Image = memoryStream.ToArray();
                }
            }

            await _context.SaveChangesAsync();

            // ✅ Save Log
            await SaveLogAsync("Edit Equipment", $"Updated Equipment ID: {equipment.Id}", "Web");

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!IsAuthenticated())
            {
                ViewBag.IsAuthenticated = false;
                return Redirect("/SignIn");
            }

            ViewBag.IsAuthenticated = true;

            try
            {
                var equipment = await _context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Available)
                    .Include(e => e.Condition)
                    .Include(e => e.FeedBacks)
                    .ThenInclude(f => f.User)
                    .FirstOrDefaultAsync(e => e.Id == id);

                if (equipment == null)
                {
                    return NotFound();
                }

                // Get current user first to avoid null reference issues
                var user = GetUserObject();
                ViewBag.User = user;
                ViewBag.IsAdminOrManager = user != null && (user.RoleId == 1 || user.RoleId == 2);
                
                // Get the FeedBackController to filter feedback based on visibility and user role
                var feedbackController = new FeedBackController(_context);
                var allFeedback = equipment.FeedBacks.ToList();
                var visibleFeedback = feedbackController.GetVisibleFeedback(allFeedback, user);
                
                ViewBag.FeedbackList = visibleFeedback;

                return View(equipment);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return View("Error");
            }
        }
    }
}
