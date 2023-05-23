using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simple.DAL;
using Simple.ViewModels;

namespace Simple.Controllers
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
            HomeVM homeVM = new HomeVM()
            {
                slider = _context.Sliders.FirstOrDefault(),
                main = _context.Mains.FirstOrDefault(),
                Abouts = _context.Abouts.Take(3).ToList(),
                questions = _context.Questions.Take(6).ToList(),
                Contact = _context.Contacts.Include(x => x.socialMedias).FirstOrDefault()

            };
            return View(homeVM);
           
        }


    }
}
