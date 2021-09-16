using System;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Secret()
        {

        }

        public IActionResult Authenticate()
        {

        }
    }
}
