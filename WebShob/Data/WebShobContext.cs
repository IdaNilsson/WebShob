using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShob.Models;

namespace WebShob.Models
{
    public class WebShobContext : DbContext
    {
        public WebShobContext (DbContextOptions<WebShobContext> options)
            : base(options)
        {
        }

        public DbSet<WebShob.Models.Product> Product { get; set; }

        public DbSet<WebShob.Models.User> User { get; set; }
    }
}
