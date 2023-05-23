using Amoeba.DAL;
using Amoeba.Models;
using Amoeba.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Amoeba.Areas.AmoebaAdmin.Controllers
{
    [Area("AmoebaAdmin")]
    public class ClientController : Controller
    {
        private readonly AppDbcontext _context;
        private readonly IWebHostEnvironment _environment;

        public ClientController(AppDbcontext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_context.clients.Include(x=>x.Profession).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Profession = _context.Professions.ToList();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            ViewBag.Profession = await _context.Professions.ToListAsync();
            if (!ModelState.IsValid) { return View(); }
            if(client != null) {
                if (!client.ImageFile.CheckFileType("/image"))
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
                if (!client.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
            }
            client.Image=await client.ImageFile.SaveFileAsync(_environment.WebRootPath,folder:"assets/img");
            await _context.AddAsync(client);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Edit(int id)
        {
            ViewBag.Profession = await _context.Professions.ToListAsync();
            return View(await _context.clients.Include(x=>x.Profession).FirstOrDefaultAsync(x=>x.Id == id));
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Client client)
        {
            ViewBag.Profession =await _context.Professions.ToListAsync();
            Client?exist=await _context.clients.Include(x=>x.Profession).FirstOrDefaultAsync(x=>x.Id == client.Id);
            if (!ModelState.IsValid) { return View(); }
            if(exist!= null)
            {
                if (!client.ImageFile.CheckFileType("/image"))
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
                if (!client.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
            }
            string path = Path.Combine(_environment.WebRootPath, "assets/img",exist.Image);
            if(System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            exist.Image = await client.ImageFile.SaveFileAsync(_environment.WebRootPath, folder: "assets/img");
            exist.Profession = client.Profession;
            exist.Id = client.Id;
            exist.Name = client.Name;
            exist.Description = client.Description;
            exist.ProfessionId = client.ProfessionId;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(int id)
        {
            Client ? exist = await _context.clients.Include(x => x.Profession).FirstOrDefaultAsync(x => x.Id ==id);
            string path = Path.Combine(_environment.WebRootPath, "assets/img", exist.Image);
            if (exist != null)
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            _context.Remove(exist);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
