using Cookies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cookies.Controllers
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
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString("userName")))
            {
                HttpContext.Session.SetString("userName", "murat");
            }

            string userName = HttpContext.Session.GetString("userName");
            return View("Session",userName);
        }

        public IActionResult Index()
        {
            string studentName = string.Empty;

            CookieOptions options = new CookieOptions();
            options.Path = "/admin";        // "/admin" sadece admin altında erişim sağlanır -- "/" bütün projede erişim sağlanır
            options.Expires = new DateTimeOffset(DateTime.Now.AddHours(5));     //cookie'yi 5 saat sonra tekrar doldur

            
            if (Request.Cookies.ContainsKey("ogrenciAdi"))
            {
                studentName=Request.Cookies["ogrenciAdi"];
            }
            else
                Response.Cookies.Append("ogrenciAdi", "Murat Genç");
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
