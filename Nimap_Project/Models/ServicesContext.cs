using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Nimap_Project.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<Product> product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
