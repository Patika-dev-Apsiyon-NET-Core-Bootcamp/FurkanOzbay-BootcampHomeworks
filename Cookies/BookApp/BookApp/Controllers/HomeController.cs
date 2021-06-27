using BookApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Session()
        {
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString("BookName")))
                HttpContext.Session.SetString("BookName","defaultkipat");

            string bookName = HttpContext.Session.GetString("BookName");
            return View("Session",bookName);
        }

        public IActionResult Index()
        {
            List<BookViewModel> model = HttpContext.Session.Get<List<BookViewModel>>("books");

            return View("Index",model);
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
