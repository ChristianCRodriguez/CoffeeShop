using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using System.Text.RegularExpressions;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        ShopDBContext db = new ShopDBContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View("~/Views/Account/Index.cshtml");
        }

        public IActionResult RegisterCustomer(Users user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return View("~/Views/Home/AuthorizedLanding.cshtml", user);
        }

        public IActionResult AuthorizedLanding()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
