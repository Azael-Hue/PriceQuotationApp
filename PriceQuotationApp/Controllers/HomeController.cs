using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;
using System.Diagnostics;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new PriceQuotation());
        }

        [HttpPost]
        public IActionResult Calculate(PriceQuotation priceQuotation)
        {
            return View(priceQuotation);
        }

        [HttpPost]
        public IActionResult Clear()
        {
            return RedirectToAction("Index");
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
