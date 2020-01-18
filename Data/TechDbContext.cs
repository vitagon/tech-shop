using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class TechDbContext : DbContext
    {
        public TechDbContext (DbContextOptions<TechDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProduct>()
                .HasKey(table => new { table.CategoryId, table.ProductId });
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<CategoryProduct> CategoryProduct { get; set; }
    }
}
