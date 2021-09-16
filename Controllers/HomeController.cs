using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using basic_auth.Data;
using basic_auth.Data.Enum;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;

namespace basic_auth.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
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

        [Authorize(Policy = "Claim.DoB")]
        public IActionResult SecretPolicy()
        {
            return View("Secret");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult SecretRole()
        {
            return View("Secret");
        }

        public IActionResult Authenticate()
        {
            var grandmaClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Bob"),
                new Claim(ClaimTypes.Email, "bob@gmail.com"),
                new Claim("Grandma.Says", "Very nice boi."),
                new Claim(ClaimTypes.DateOfBirth, "01/01/2000"),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var licenseClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Bob"),
                new Claim("Driving License", "A+")
            };

            var grandmaIdentity = new ClaimsIdentity(grandmaClaims, "Grandma Identity");
            var licenseIdentity = new ClaimsIdentity(licenseClaims, "License Identity");

            var userPrinciple = new ClaimsPrincipal(new[] { grandmaIdentity, licenseIdentity });

            HttpContext.SignInAsync(userPrinciple);

            return RedirectToAction("Index");
        }
    }
}
