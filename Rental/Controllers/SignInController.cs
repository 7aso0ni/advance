using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ClassLibrary.Models;
using System.Text;
using Newtonsoft.Json;

namespace Rental.Controllers
{
    public class SignInController : BaseController
    {

        public SignInController(ClassLibrary.Persistence.DBContext context) : base(context)
        {

        }

        [HttpPost]
        public IActionResult SignIn(string username, string password)
        {
            try
            {
                // fetch the user from the database. if user was not found throw an exception
                var user = _context.Users
                    .FirstOrDefault(u => u.Email == username && u.Password == password) ?? throw new Exception("User not fonud");

                var json = JsonConvert.SerializeObject(user);
                var credBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

                Response.Cookies.Append("credentials", credBase64, new CookieOptions
                {
                    Secure = true,
                    HttpOnly = true,
                    Expires = DateTime.UtcNow.AddHours(24)
                });

                ViewBag.Message = "User logged Successfully";

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }

            return Redirect("/Home");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
