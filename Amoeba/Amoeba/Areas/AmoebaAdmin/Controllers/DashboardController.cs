using Microsoft.AspNetCore.Mvc;

namespace Amoeba.Areas.AmoebaAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("AmoebaAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
