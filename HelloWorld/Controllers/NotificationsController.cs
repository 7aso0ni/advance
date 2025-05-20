using ClassLibrary.Models;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    public class NotificationsController : BaseController
    {
        public NotificationsController(DBContext context) : base(context) { }

        public async Task<IActionResult> Index()
        {
            var user = GetUserObject();
            if (user == null)
            {
                TempData["ErrorMessage"] = "You must be logged in to view notifications.";
                return RedirectToAction("Index", "SignIn");
            }

            var notifications = await _context.Notifications
                .Where(n => n.UserId == user.Id)
                .Include(n => n.NotificationType)
                .OrderByDescending(n => n.DateTime)
                .ToListAsync();

            return View(notifications);
        }

        [HttpPost]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            var user = GetUserObject();
            if (user == null)
            {
                return Unauthorized();
            }

            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null || notification.UserId != user.Id)
            {
                return NotFound();
            }

            notification.Status = 1; // Mark as read
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> MarkAllAsRead()
        {
            var user = GetUserObject();
            if (user == null)
            {
                return Unauthorized();
            }

            var notifications = await _context.Notifications
                .Where(n => n.UserId == user.Id && n.Status == 0)
                .ToListAsync();

            foreach (var notification in notifications)
            {
                notification.Status = 1; // Mark as read
            }

            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "All notifications marked as read.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var user = GetUserObject();
            if (user == null)
            {
                return Unauthorized();
            }

            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null || notification.UserId != user.Id)
            {
                return NotFound();
            }

            _context.Notifications.Remove(notification);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAll()
        {
            var user = GetUserObject();
            if (user == null)
            {
                return Unauthorized();
            }

            var notifications = await _context.Notifications
                .Where(n => n.UserId == user.Id)
                .ToListAsync();

            _context.Notifications.RemoveRange(notifications);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "All notifications deleted.";
            return RedirectToAction("Index");
        }

        // API endpoint to get unread notification count
        [HttpGet]
        public async Task<IActionResult> GetUnreadCount()
        {
            var user = GetUserObject();
            if (user == null)
            {
                return Json(new { count = 0 });
            }

            var count = await _context.Notifications
                .CountAsync(n => n.UserId == user.Id && n.Status == 0);

            return Json(new { count });
        }
    }
}
