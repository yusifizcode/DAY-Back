using Day.Areas.Manage.ViewModels;
using Day.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> CreateAdmin()
        //{
        //    //var existAdmin = await _userManager.Users.FirstOrDefaultAsync(x => x.IsAdmin && x.UserName == admin.UserName);

        //    //if (existAdmin == null)
        //    //    return RedirectToAction("login", "account");

        //    if (!ModelState.IsValid)
        //        return View();

        //    AppUser user = new AppUser
        //    {
        //        FullName = "Super Admin",
        //        UserName = "SuperAdmin",
        //        IsAdmin = true
        //    };

        //    var result = await _userManager.CreateAsync(user, "Admin123");

        //    if (!result.Succeeded)
        //    {
        //        return View(result.Errors);
        //    }

        //    return View();
                
        //}

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel admin)
        {
            var existAdmin = await _userManager.Users.FirstOrDefaultAsync(x => x.IsAdmin && x.UserName == admin.UserName);

            if(existAdmin == null)
                return RedirectToAction("login", "account");



            var result = await _signInManager.PasswordSignInAsync(existAdmin,admin.PassWord,false,false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is not correct!");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }

        public async Task<IActionResult> SignOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("index", "account");
        }
    }
}
