using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
