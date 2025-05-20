using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Rental.Controllers
{
    public class EquipmentController : BaseController
    {
        public EquipmentController(ClassLibrary.Persistence.DBContext context) : base(context)
        {
        }
        public async Task<IActionResult> Index()
        {
            if (!IsAuthenticated())
            {
                return Redirect("/SignIn");
            }

            try
            {
                var equipmentList = _context.Equipment.Select(e => e).ToListAsync();
                ViewBag.EquipmentList = equipmentList;
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
            }
            return View(ViewBag);
        }
    }
}
