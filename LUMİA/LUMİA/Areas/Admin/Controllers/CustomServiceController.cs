using LUMİA.DAL;
using LUMİA.Models;
using LUMİA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace LUMİA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomServiceController : Controller
    {
        private readonly AppDbContext _context;
        public CustomServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int take=2,int page=1)
        {
          var service=  _context.Services.Skip((page-1)*take).Take(take).ToList();
            PaginateVM<CustomService> paginateVM = new PaginateVM<CustomService>()
            {
                Items = service,
                PageCount = PageCount(take),
                CurrentPage = page
            };

            return View(paginateVM);
        }
        public int PageCount(int take)
        {
            var count = _context.Services.Count();
            return (int)Math.Ceiling((double)count / take);
        }
        public IActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Create(CustomService customService)
        {
            if(!ModelState.IsValid) { return View(); }
            await _context.Services.AddAsync(customService);
            await _context.SaveChangesAsync();  
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View(await _context.Services.FirstOrDefaultAsync(x => x.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomService customService)
        {
            CustomService?exist= await _context.Services.FirstOrDefaultAsync(x=>x.Id == customService.Id);
            if(!ModelState.IsValid) return View();
            exist.Title=customService.Title;
            exist.Description=customService.Description;
            exist.Icon=customService.Icon;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(int id)
        {
            CustomService?exist= await _context.Services.FirstOrDefaultAsync(x=>x.Id==id);
            if (!ModelState.IsValid) { return View(); } 
            _context.Services.Remove(exist);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
