using Microsoft.AspNetCore.Mvc;

namespace Simple.Areas.SimpleAdmin.Controllers
{
    [Area("SimpleAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
