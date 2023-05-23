using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class ServisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
