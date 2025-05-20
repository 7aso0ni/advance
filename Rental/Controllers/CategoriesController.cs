using Microsoft.AspNetCore.Mvc;

namespace Rental.Controllers
{
    public class CategoriesController : BaseController
    {

        public CategoriesController(ClassLibrary.Persistence.DBContext context): base(context)
        {

        }
        public IActionResult Index()
        {
            if (!IsAuthenticated()) return Redirect("/SignIn");
            return View();
        }

        public IActionResult GetCategories()
        {
            try
            {
                IEnumerable<ClassLibrary.Models.Category> categories = _context.Categories; 
            }
            catch (Exception e)
            {
                return Json(new { error = e.Message });
            }

            return View(ViewBag);
        }
    }
}
