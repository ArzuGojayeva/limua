using Amoeba.DAL;
using Amoeba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Amoeba.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbcontext _context;
        public HomeController(AppDbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                About = _context.about.FirstOrDefault(),
                clients=_context.clients.ToList(),
                contact=_context.contacts.FirstOrDefault(),
                Services=_context.services.Take(6).ToList(), 
                Profession=_context.Professions.FirstOrDefault(),
                Questions=_context.questions.Take(6).ToList(),
                
            };
            return View();
        }
    }
}
