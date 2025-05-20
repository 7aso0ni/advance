using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Newtonsoft.Json;

namespace Rental.Controllers
{
    public class SignUpController : BaseController
    {
        public SignUpController(ClassLibrary.Persistence.DBContext context) : base(context) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckAccount()
        {
            IEnumerable<ClassLibrary.Models.User> users = _context.Users;
            return Json(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match!";
                return View("Index");
            }

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (existingUser != null)
            {
                ViewBag.ErrorMessage = "Email already in use!";
                return View("Index");
            }

            var user = new User
            {
                Fname = firstName,
                Lname = lastName,
                Email = email,
                Password = password,
                RoleId = 3
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // ✅ Save Log for account creation
            await SaveLogAsync("Create Account", $"New User: {user.Email}", "Web");

            TempData["SuccessMessage"] = "Account successfully created! You can now sign in.";

            var json = JsonConvert.SerializeObject(user);
            var credBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

            Response.Cookies.Append("credentials", credBase64, new CookieOptions
            {
                Secure = true,
                HttpOnly = true,
                Expires = DateTimeOffset.UtcNow.AddHours(24)
            });

            return Redirect("/Home");
        }
    }
}
