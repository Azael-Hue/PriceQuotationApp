using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            PriceQuotation newQuote = new()
            {
                Subtotal = 0,
                DiscountPercent = 0
            };
            return View( newQuote );
        }

        [HttpPost]
        public IActionResult Index( PriceQuotation quote )
        {
            return View(quote);
        }
        
    }
}
