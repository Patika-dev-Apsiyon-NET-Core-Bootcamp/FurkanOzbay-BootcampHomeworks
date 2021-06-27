using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class InitController : Controller
    {
        public IActionResult Index()
        {
            List<BookViewModel> books = new List<BookViewModel>() {
                new BookViewModel{Id=1,BookName="Safahat",Price=23,Author="Peyami Safa",PageNumbers=56 },
                new BookViewModel{Id=2,BookName="olmaz öyle saçma tarih",Price=21,Author="ESG",PageNumbers=56 },
                new BookViewModel{Id=3,BookName="Sapiens",Price=40,Author="Harari",PageNumbers=56 },
                new BookViewModel{Id=4,BookName="Kinyas ve Kayra",Price=15,Author="Hakan GÜnday",PageNumbers=56 }
            };

            HttpContext.Session.Set<List<BookViewModel>>("books", books);

            return RedirectToAction("Index","Home");
        }
    }
}
