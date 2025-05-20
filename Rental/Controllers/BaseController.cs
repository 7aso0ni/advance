using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Rental.Controllers
{
    public class BaseController : Controller
    {
        internal readonly ClassLibrary.Persistence.DBContext? _context;

        // Constructor injection
        public BaseController(ClassLibrary.Persistence.DBContext context)
        {
            _context = context;
        }

        public bool IsAuthenticated()
        {
            // try getting the credentials cookie, if it exists it will return true to inform the method that the user is authenticated, otherwise return false
            return Request.Cookies.TryGetValue("credentials", out string? userCookie) && !string.IsNullOrWhiteSpace(userCookie);
        }

        public User? GetUserObject()
        {
            // try getting the credentials cookie, if it exists it will return the user object, otherwise return null
            if (!Request.Cookies.TryGetValue("credentials", out string? userCookie) || userCookie == null)
            {
                return null;
            }
            var cookieValue = Encoding.UTF8.GetString(Convert.FromBase64String(userCookie));
            var user = JsonConvert.DeserializeObject<User>(cookieValue);
            return user;
        }
    }
}
