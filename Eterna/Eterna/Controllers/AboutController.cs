using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
