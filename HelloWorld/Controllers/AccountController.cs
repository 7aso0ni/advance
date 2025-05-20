using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Rental.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            
            Response.Cookies.Delete("credentials");

            return Redirect("/Home");
        }
    }
}
