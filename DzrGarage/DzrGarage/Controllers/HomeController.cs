using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DzrGarage.Models;

namespace DzrGarage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boxes()
        {
            var boxes = new List<Box>()
            {
                new Box(){Id = 18, Name = "Box №18", UserId = "63f43fc4-7ce2-4016-babd-e1c145d723b0"},
                new Box(){Id = 17, Name = "Box №17", UserId = "63f43fc4-7ce2-4016-babd-e1c145d723b0"}
            };

            return View(boxes);
        }

        public IActionResult Balance()
        {
            return View();
        }

        public IActionResult Contacts()
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
