using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using Simple.DAL;
using Simple.Models;
using Simple.Utilities.Extension;

namespace Simple.Areas.SimpleAdmin.Controllers
{
    [Area("SimpleAdmin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        private readonly IWebHostEnvironment _environment;

      
        [Area("SimpleAdmin")]
        public async Task< IActionResult> Index()
        {
            return View(await _context.Abouts.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Create(About about)
        {
            if (!ModelState.IsValid) return View();
            if (about != null)
            {
                if (!about.ImageFile.CheckFileType("image/"))
                {
                    ModelState.AddModelError("AboutController", "Wrong");
                    return View();
                }
                if (!about.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("AboutController", "Wrong");
                    return View();
                }
            }
            about.Image = await about.ImageFile.SaveFile(_environment.WebRootPath);
            await _context.AddAsync(about);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult>Edit(int id)
        {
            return View(_context.Abouts.FirstOrDefaultAsync(x => x.Id == id));
        }
        [HttpPost]
        public async Task<IActionResult>Edit(About? about)
        {
            About? exist = await _context.Abouts.FirstOrDefaultAsync(x => x.Id == about.Id);
            if (exist != null)
            {
                if (!about.ImageFile.CheckFileType("image/"))
                {
                    ModelState.AddModelError("AboutController", "Wrong");
                    return View();
                }
                if (!about.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("AboutController", "Wrong");
                    return View();
                }
            }

            string oldpath = Path.Combine(_environment.WebRootPath, "assets/img", exist.Image);

            if (System.IO.File.Exists(oldpath))
            {
                System.IO.File.Delete(oldpath);
            }

            exist.Image = await about.ImageFile.SaveFile(_environment.WebRootPath);

            exist.Id = about.Id;
            exist.Title = about.Title;
            exist.Icon = about.Icon;
            exist.Description = about.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
   
        public async Task<IActionResult>Delete(int id)
        {
            About? exist = await _context.Abouts.FirstOrDefaultAsync(x => x.Id == id);
            string oldpath = Path.Combine(_environment.WebRootPath, "assets/img", exist.Image);

            if (System.IO.File.Exists(oldpath))
            {
                System.IO.File.Delete(oldpath);
            }

            _context.Remove(exist);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
