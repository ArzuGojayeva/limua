using LUMİA.DAL;
using LUMİA.Models;
using LUMİA.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LUMİA.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(RoleManager<IdentityRole> rolemanager, SignInManager<AppUser> signInManager, UserManager<AppUser> usermanager)
        {
            _rolemanager = rolemanager;
            _signInManager = signInManager;
            _usermanager = usermanager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(!ModelState.IsValid) { return View(); }
            AppUser newUser=new AppUser()
            {
                UserName= registerVM.UserName,
                Email = registerVM.Email,
            };
            IdentityResult result=await _usermanager.CreateAsync(newUser,registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
            }
            await _signInManager.SignInAsync(newUser, false);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) { return View(); }
            AppUser user=await _usermanager.FindByNameAsync(loginVM.UserName);
            var result= await _signInManager.PasswordSignInAsync(user, loginVM.Password,false,true);
            if (!result.Succeeded)
            {
                    ModelState.AddModelError("", "Error");
                    return View();
            }
            if(result.IsLockedOut)
            {
                ModelState.AddModelError("", "Error");
                return View();
            }

            return RedirectToAction("Index","Home");
        }

    }
}
