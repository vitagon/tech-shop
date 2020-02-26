using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;
using TechShop.Views;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            modelBuilder.Entity<Vw_CategoryProducts>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vw_CategoryProducts");
            });
        }

        public DbSet<Breadcrumb> Breadcrumb { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<CategoryProduct> CategoryProduct { get; set; }

        public DbSet<Vw_CategoryProducts> Vw_CategoryProducts { get; set; }
    }
}
