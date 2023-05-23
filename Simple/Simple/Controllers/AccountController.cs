using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Simple.Models;
using Simple.ViewModels;

namespace Simple.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinmanager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public IActionResult Register()
        {
            return View();
        }
        public async Task<IActionResult>Register(RegisterVm registerVm)
        {
            if(!ModelState.IsValid) { return View(); }
            AppUser appUser = new AppUser()
            {
                Id = registerVm.Id;

            };
            return RedirectToAction("Index", "Home");
        }
    }
}
