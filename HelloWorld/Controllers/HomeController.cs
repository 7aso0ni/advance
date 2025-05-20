using System.Diagnostics;
using System.Text;
using ClassLibrary.Models;
using Rental.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rental.Models;

namespace Rental.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) : base(null)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.IsAuthenticated = IsAuthenticated();
            return View(ViewBag);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
