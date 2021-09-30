using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Resources;
using Website.Data;
using Website.Models;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        private readonly WebsiteContext websiteContext;

        public AdminController(WebsiteContext websiteContext)
        {
            this.websiteContext = websiteContext;
        }
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
        public async Task<IActionResult> AddProject(string title, string content, string footer)
        {
            var contacts = websiteContext.Project;

            contacts.Add(new Project
            {
                Title = title,
                Content = content,
                Footer = footer
            });

            await websiteContext.SaveChangesAsync();
            return View();
        }

        public IActionResult ProjectList()
        {
            return View(websiteContext.Project.ToList());
        }

        [HttpGet]
        public IActionResult ModifProject(int id)
        {
            var project = websiteContext.Project.First(p => p.ID == id);

            return View(project);
        }

        [HttpPost]
        public IActionResult ModifProject(string title, string content, string footer)
        {
            return View();
        }
    }
}
