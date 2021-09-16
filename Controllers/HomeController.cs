using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using basic_auth.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace basic_auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            // Login functionality
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return NotFound();
            }

            // Sign user here
            var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

            if (!signInResult.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string userName, string password)
        {
            var user = new IdentityUser
            {
                UserName = userName,
                Email = ""
            };

            var result = await _userManager.CreateAsync(user, password);

            if (!result.Succeeded)
            {
                return UnprocessableEntity();
            }

            // Sign user here
            var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

            if (!signInResult.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}
