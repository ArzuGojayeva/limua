using Amoeba.Models;
using Amoeba.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Amoeba.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
        }
        public IActionResult Register()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(!ModelState.IsValid) { return View(); }
            AppUser user=new AppUser()
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email,
               
            };
            IdentityResult result=await _usermanager.CreateAsync(user,registerVM.Password);
            if(!result.Succeeded)
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", "Error");
                    return View();
                }
            }
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid) { return View(); }
            AppUser? user=await _usermanager.FindByNameAsync(loginVM.UserName);
            if (user != null)
            {
               var result= await _signInManager.PasswordSignInAsync(user.UserName, loginVM.Password,false,true);
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
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
