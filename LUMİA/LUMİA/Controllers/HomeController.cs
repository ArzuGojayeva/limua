using LUMİA.DAL;
using LUMİA.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LUMİA.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM=new HomeVM()
            {
                customServices=_context.Services.Take(6).ToList(),
                slider=_context.Slider.FirstOrDefault(),
                Teams=_context.Teams.Take(3).ToList(),
                Whats=_context.Whats.Take(3).ToList(),
               
            };
            return View(homeVM);
        }
    }
}
