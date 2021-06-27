using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString("userName")))
                HttpContext.Session.SetString("BookName", "ff");

            return View();
        }
    }
}
