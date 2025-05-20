using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Rental.Controllers
{
    public class FeedBackController : BaseController
    {
        public FeedBackController(ClassLibrary.Persistence.DBContext context) : base(context) 
        { 
            // Initialize feedback visibility for all existing feedback if dictionary is empty
            if (FeedbackVisibility.Count == 0)
            {
                InitializeFeedbackVisibility();
            }
        }
        
        private static Dictionary<int, bool> FeedbackVisibility = new();

        [HttpPost]
        public IActionResult Create(FeedBack feedback)
        {
            // 1️⃣ Ensure User is Logged In
            var user = GetUserObject(); // Get user from cookie
            if (user == null)
            {
                TempData["ErrorMessage"] = "You must be logged in to leave feedback.";
                return RedirectToAction("Details", "Equipment", new { id = feedback.Equipment });
            }

            // 2️⃣ Populate Required Fields
            feedback.UserId = user.Id; // Set the logged-in user ID
            feedback.Date = DateTime.Now;
            feedback.Time = TimeOnly.FromDateTime(DateTime.Now);

            // Ensure Equipment Exists
            var equipmentExists = _context.Equipment.Any(e => e.Id == feedback.Equipment);
            if (!equipmentExists)
            {
                TempData["ErrorMessage"] = "Invalid equipment selected.";
                return RedirectToAction("Index", "Equipment");
            }

            // 3️⃣ Save to Database
            _context.FeedBacks.Add(feedback);
            _context.SaveChanges();
            FeedbackVisibility[feedback.Id] = true; // Show by default


            TempData["SuccessMessage"] = "Feedback submitted successfully!";
            return RedirectToAction("Details", "Equipment", new { id = feedback.Equipment });
        }
        
        [HttpPost]
        public IActionResult ToggleFeedbackVisibility(int id)
        {
            try
            {
                // Check if user is admin or manager (RoleId 1 or 2)
                var user = GetUserObject();
                if (user == null || (user.RoleId != 1 && user.RoleId != 2))
                {
                    TempData["ErrorMessage"] = "You do not have permission to manage feedback visibility.";
                    return RedirectToAction("Index", "Home");
                }
                
                // Check if the feedback exists
                var feedback = _context.FeedBacks.Find(id);
                if (feedback == null)
                {
                    TempData["ErrorMessage"] = "Feedback not found.";
                    return RedirectToAction("ManageFeedback");
                }

                // Toggle visibility
                if (FeedbackVisibility.ContainsKey(id))
                    FeedbackVisibility[id] = !FeedbackVisibility[id];
                else
                    FeedbackVisibility[id] = false; // Hide by default if missing

                // Get the current state after toggling
                bool isVisible = FeedbackVisibility[id];
                
                // Log the action
                string action = isVisible ? "showed" : "hid";
                _ = SaveLogAsync($"{action} feedback", $"Feedback ID: {id}", "Web");

                // Provide clear feedback to the user about what happened
                TempData["SuccessMessage"] = $"Feedback #{id} is now {(isVisible ? "visible" : "hidden")}.";
                
                // Get the equipment ID to redirect back to the correct page if needed
                var equipmentId = feedback.Equipment;
                
                // Store the current visibility state in TempData for debugging
                TempData["DebugInfo"] = $"Feedback #{id} visibility set to {isVisible}. Dictionary now has {FeedbackVisibility.Count} items.";
                
                return RedirectToAction("ManageFeedback");
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error in ToggleFeedbackVisibility: {ex.Message}");
                TempData["ErrorMessage"] = "An error occurred while updating feedback visibility. Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }
        
        public IActionResult ManageFeedback()
        {
            try
            {
                // Check if user is admin or manager (RoleId 1 or 2)
                var user = GetUserObject();
                if (user == null || (user.RoleId != 1 && user.RoleId != 2))
                {
                    TempData["ErrorMessage"] = "You do not have permission to access this page.";
                    return RedirectToAction("Index", "Home");
                }

                var feedbacks = _context.FeedBacks
                    .Include(f => f.User)
                    .Include(f => f.EquipmentNavigation)
                    .OrderByDescending(f => f.Date)
                    .ToList();

                ViewBag.FeedbackVisibility = FeedbackVisibility;
                return View(feedbacks);
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error in ManageFeedback: {ex.Message}");
                TempData["ErrorMessage"] = "An error occurred while loading feedback. Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }
        
        // Initialize feedback visibility dictionary with all existing feedback
        private void InitializeFeedbackVisibility()
        {
            try
            {
                var allFeedback = _context.FeedBacks.ToList();
                foreach (var feedback in allFeedback)
                {
                    if (!FeedbackVisibility.ContainsKey(feedback.Id))
                    {
                        // Default all feedback to visible
                        FeedbackVisibility[feedback.Id] = true;
                    }
                }
                
                Console.WriteLine($"Initialized visibility for {allFeedback.Count} feedback items");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing feedback visibility: {ex.Message}");
            }
        }
        
        // Get visible feedback for equipment details page
        public List<FeedBack> GetVisibleFeedback(List<FeedBack> allFeedback, User currentUser = null)
        {
            // If user is admin or manager, they can see all feedback regardless of visibility
            var user = currentUser ?? GetUserObject();
            bool isAdminOrManager = user != null && (user.RoleId == 1 || user.RoleId == 2);
            
            if (isAdminOrManager)
            {
                return allFeedback;
            }
            
            // Make sure all feedback items have visibility settings
            foreach (var feedback in allFeedback)
            {
                if (!FeedbackVisibility.ContainsKey(feedback.Id))
                {
                    FeedbackVisibility[feedback.Id] = true; // Default to visible
                }
            }
            
            // For regular users, only show visible feedback
            return allFeedback.Where(f => FeedbackVisibility[f.Id]).ToList();
        }
    }
}
