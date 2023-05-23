using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
