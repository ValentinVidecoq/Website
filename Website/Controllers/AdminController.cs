using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(string title, string content, string footer)
        {
            return View();
        }

        [HttpGet]
        public IActionResult ModifProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModifProject(string title, string content, string footer)
        {
            return View();
        }
    }
}
