using Microsoft.AspNetCore.Mvc;
using System.Text;
using Newtonsoft.Json;
using Rental.Models;
using ClassLibrary.Models;

namespace Rental.Controllers
{
    public class SignInController : BaseController
    {
        public SignInController(ClassLibrary.Persistence.DBContext context) : base(context) { }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SignInViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "Invalid input.";
                return View("Index", model);
            }

            try
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Email == model.Username && u.Password == model.Password)
                    ?? throw new Exception("User not found");

                var json = JsonConvert.SerializeObject(user);
                var credBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

                Response.Cookies.Append("credentials", credBase64, new CookieOptions
                {
                    Secure = true,
                    HttpOnly = true,
                    Expires = DateTime.UtcNow.AddHours(24)
                });

                await SaveLogManualUserIdAsync(user.Id, $"{user.Fname} {user.Lname}", "Login", $"User {user.Fname} {user.Lname} logged in", "Web");

                model.Message = "User logged in successfully!";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                model.ErrorMessage = ex.Message;
                return View("Index", model);
            }
        }
    }
}
