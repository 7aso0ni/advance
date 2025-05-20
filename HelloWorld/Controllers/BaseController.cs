using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewBag.User = GetUserObject();
            ViewBag.IsAuthenticated = ViewBag.User != null;
            base.OnActionExecuting(context);
        }
        protected async Task SaveLogAsync(string action, string affectedData, string source)
        {
            if (_context != null)
            {
                var user = GetUserObject();
                if (user != null)
                {
                    var fullName = $"{user.Fname} {user.Lname}";

                    var log = new Log
                    {
                        Action = $"{action} by {fullName}", // ✨ show name in action field
                        TimeStamp = DateTime.UtcNow,
                        AffectedData = affectedData,
                        Source = source,
                        UserId = user.Id
                    };

                    _context.Logs.Add(log);
                    await _context.SaveChangesAsync();
                }
            }
        }

        protected async Task SaveLogManualUserIdAsync(int userId, string fullName, string action, string affectedData, string source)
        {
            if (_context != null)
            {
                var log = new Log
                {
                    Action = action,
                    TimeStamp = DateTime.UtcNow,
                    AffectedData = affectedData,
                    Source = source,
                    UserId = userId
                };

                _context.Logs.Add(log);
                await _context.SaveChangesAsync();
            }
        }
        protected async Task SaveNotificationAsync(string title, string message, int notificationTypeId = 1, int? status = 0)
        {
            if (_context != null)
            {
                var user = GetUserObject();
                if (user == null)
                {
                    Console.WriteLine("❌ Notification not saved — user is null.");
                    return;
                }

                Console.WriteLine($"✅ Saving Notification for {user.Fname} {user.Lname}");

                var notification = new Notification
                {
                    Message = message,
                    DateTime = DateTime.UtcNow,
                    UserId = user.Id,
                    NotificationTypeId = notificationTypeId,
                    Status = status
                };

                _context.Notifications.Add(notification);
                await _context.SaveChangesAsync();

                Console.WriteLine("✅ Notification saved.");
            }
        }





    }
}
