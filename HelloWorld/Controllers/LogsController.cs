using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rental.Controllers
{
    public class LogsController : BaseController
    {
        public LogsController(DBContext context) : base(context) { }

        public async Task<IActionResult> Index(string actionFilter = "", string userFilter = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            var user = GetUserObject();
            if (user == null || user.RoleId != 1)
            {
                return RedirectToAction("Index", "Home");
            }

            var logsQuery = _context.Logs
                .Include(l => l.User)
                .AsQueryable();

            if (!string.IsNullOrEmpty(actionFilter))
            {
                logsQuery = logsQuery.Where(l => l.Action.Contains(actionFilter));
            }

            if (!string.IsNullOrEmpty(userFilter))
            {
                logsQuery = logsQuery.Where(l => l.User.Email.Contains(userFilter));
            }

            if (startDate.HasValue)
            {
                logsQuery = logsQuery.Where(l => l.TimeStamp >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                logsQuery = logsQuery.Where(l => l.TimeStamp <= endDate.Value);
            }

            var logs = await logsQuery.OrderByDescending(l => l.TimeStamp).ToListAsync();

            return View(logs);
        }
    }
}
