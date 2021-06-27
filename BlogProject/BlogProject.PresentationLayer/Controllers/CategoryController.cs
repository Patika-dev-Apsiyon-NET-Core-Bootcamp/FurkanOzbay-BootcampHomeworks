using BlogProject.BusinessLayer.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        public IActionResult Index()
        {
            var model=categoryBusiness.GetCategories();
            return View(model);
        }
    }
}
