using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rental.Controllers
{
    public class MyRentals : BaseController
    {
        public MyRentals(ClassLibrary.Persistence.DBContext context) : base(context) { }

        public IActionResult Index()
        {
            if (!IsAuthenticated())
                return RedirectToAction("Index", "SignIn");

            var user = GetUserObject();
            ViewBag.User = user;

            int? userId = user?.Id;

            var rentalHistory = _context.RentalRequests
                .Where(r => r.UserId == userId)
                .Include(r => r.Equipment)
                .Include(r => r.RentalStatus1)
                .ToList();

            return View(rentalHistory);
        }

    }
}
