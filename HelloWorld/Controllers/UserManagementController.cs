using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using System.Threading.Tasks;

namespace Rental.Controllers
{
    public class UserManagementController : BaseController
    {
        public UserManagementController(DBContext context) : base(context) { }

        public IActionResult ManageUsers()
        {
            var user = GetUserObject();
            if (user == null || user.RoleId != 1) return RedirectToAction("Index", "Home");

            var users = _context.Users
     .Include(u => u.Role)
     .Include(u => u.Documents)
         .ThenInclude(d => d.DocumentTypeNavigation)
     .Where(u => u.RoleId != 1)
     .ToList();


            return View(users);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePassword(int id, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                TempData["Error"] = "New password cannot be empty.";
                return RedirectToAction("ManageUsers");
            }

            try
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                {
                    TempData["Error"] = "User not found.";
                    return RedirectToAction("ManageUsers");
                }

                user.Password = newPassword.Trim();
                await _context.SaveChangesAsync();

                // ✅ Save log after successful password update
                await SaveLogAsync("Update Password", $"Password updated for UserID: {user.Id}", "Web");

                TempData["Success"] = $"Password updated successfully for {user.Email}.";
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while updating the password.";
            }

            return RedirectToAction("ManageUsers");
        }
        [HttpGet]
        public async Task<IActionResult> UserDocuments(int userId)
        {
            var user = await _context.Users.Include(u => u.Documents)
                                           .ThenInclude(d => d.DocumentTypeNavigation)
                                           .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("ManageUsers");
            }

            ViewBag.UserName = $"{user.Fname} {user.Lname}";
            return View(user.Documents.ToList());
        }
        [HttpGet]
        public async Task<IActionResult> DownloadDocument(int id)
        {
            var document = await _context.Documents.FirstOrDefaultAsync(d => d.Id == id);
            if (document == null)
                return NotFound("Document not found.");

            return File(document.StoragePath, document.FileType, document.FileName);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            var doc = await _context.Documents.FindAsync(id);
            if (doc == null)
            {
                TempData["Error"] = "Document not found.";
                return RedirectToAction("ManageUsers");
            }

            _context.Documents.Remove(doc);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Document deleted successfully.";
            return RedirectToAction("ManageUsers"); // 👈 redirect back to main page
        }



    }

}
