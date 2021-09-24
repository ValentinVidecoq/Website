using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Data;
using Website.Models;

namespace Website.Controllers
{
    public class ContactController : Controller
    {
        public WebsiteContext WebsiteContext { get; }

        public ContactController(WebsiteContext websiteContext)
        {
            WebsiteContext = websiteContext;
        }
        public IActionResult Index ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string name, string email, string message)
        {
            var contacts = WebsiteContext.Contact;

            contacts.Add(new Contact
            {
                name = name,
                email=email,
                message=message
            });

            await WebsiteContext.SaveChangesAsync();
            return View();
        }
    }
}
