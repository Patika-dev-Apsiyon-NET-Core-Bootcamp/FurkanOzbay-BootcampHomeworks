using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookViewModel bookViewModel = new BookViewModel();
            bookViewModel.Id = 1;
            bookViewModel.BookName = "X";
            bookViewModel.Author = "furkan";
            bookViewModel.Date = DateTime.Now;
            bookViewModel.Price = 4;
            bookViewModel.Categories.Add("Polisiye");
            bookViewModel.Categories.Add("Bilim Kurgu");

            if (HttpContext.Session.Get<BookViewModel>("book") == default)
                HttpContext.Session.Set<BookViewModel>("book", bookViewModel);


            return View();
        }

        [HttpPost]
        public IActionResult Index(BookViewModel model)
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {

            List<BookViewModel> model = HttpContext.Session.Get<List<BookViewModel>>("books");
            BookViewModel book = model.FirstOrDefault(x => x.Id == Id);

            return View("Detail", book);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            List<BookViewModel> books= HttpContext.Session.Get<List<BookViewModel>>("books");
            books.Add(model);

            return RedirectToAction("Index","Home");
        }
    }
}
