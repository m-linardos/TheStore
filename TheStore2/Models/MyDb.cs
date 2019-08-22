using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStore2.Models
{
    public class MyDb : DbContext            //MyDB inherits from DbContext 
    {                                           //using statement
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public MyDb(DbContextOptions options) : base(options)
        {
        }
    }


}

