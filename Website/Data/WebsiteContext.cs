using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Website.Models;

namespace Website.Data
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext (DbContextOptions<WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Website.Models.Contact> Contact { get; set; }
        public DbSet<Website.Models.Project> Project { get; set; }
    }
}
