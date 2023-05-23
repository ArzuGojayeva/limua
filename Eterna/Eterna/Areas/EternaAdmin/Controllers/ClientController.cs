using Eterna.DAL;
using Eterna.Models;
using Eterna.Utilities.Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Areas.EternaAdmin.Controllers
{
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public ClientController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(Client client)
        {
            if(!ModelState.IsValid) { return View(); }
            if(client!=null)
            {
                if (!client.ImageFile.CheckFileType("image?"))
                {
                    ModelState.AddModelError("", "Error");
                }
                if (client.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("", "Error");
                }
                
            }
            client.Image = await client.ImageFile.SaveFileAsync(_environment.WebRootPath, "admin/images");
            await _context.AddAsync(client);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async IActionResult Edit(int id)
        {
            return View(await _context.Clients.FirstOrDefaultAsync(x=>x.Id==id));
        }
        public async Task<IActionResult>Edit(Client client)
        {
            if (!ModelState.IsValid) { return View(); }
            Client? exist=await _context.Clients.FirstOrDefaultAsync(x=>x.Id==client.Id);
            if (exist != null)
            {
                if (!client.ImageFile.CheckFileType("image?"))
                {
                    ModelState.AddModelError("", "Error");
                }
                if (client.ImageFile.CheckFileSize(2000))
                {
                    ModelState.AddModelError("", "Error");
                }
            }




            return RedirectToAction("Index");

        }
    }
}
