using RecapProject1.Entites;
using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RecapProject1
{
    public class NorthwindContext : DbContext
    {
      public  DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
