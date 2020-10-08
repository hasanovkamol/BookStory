using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStory.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult About()
        {
            ViewData["title"] = "About Page ||";
            return View();
        }
    }
}
