using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClothShop.Models;

namespace ClothShop.Data
{
    public class ClothShopContext : DbContext
    {
        public ClothShopContext (DbContextOptions<ClothShopContext> options)
            : base(options)
        {
        }

        public DbSet<ClothShop.Models.Order> Order { get; set; }

        public DbSet<ClothShop.Models.Customer> Customer { get; set; }

        public DbSet<ClothShop.Models.Brand> Brand { get; set; }

        public DbSet<ClothShop.Models.Category> Category { get; set; }
    }
}
