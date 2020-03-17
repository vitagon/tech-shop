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

            modelBuilder.Entity<ProductPAVPair>()
                .HasKey(table => new { table.ProductId, table.AVPairId });

            modelBuilder.Entity<PFilterPAVPair>()
                .HasKey(table => new { table.FilterId, table.AVPairId });
            

            modelBuilder.Entity<Vw_CategoryProduct>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vw_CategoryProduct");
            });


            modelBuilder.Entity<Vw_Product>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vw_Product");
            });

            modelBuilder.SeedData();
        }

        public DbSet<Breadcrumb> Breadcrumb { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PriceHistory> PriceHistory { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<CategoryProduct> CategoryProduct { get; set; }
        public DbSet<PAttribute> PAttribute { get; set; }
        public DbSet<PValue> PValue { get; set; }
        public DbSet<PAVPair> PAVPair { get; set; }
        public DbSet<ProductPAVPair> ProductPAVPair { get; set; }
        public DbSet<PFilterName> PFilterName { get; set; }
        public DbSet<PFilterValue> PFilterValue { get; set; }
        public DbSet<PFilter> PFilter { get; set; }
        public DbSet<PFilterPAVPair> PFilterPAVPair { get; set; }

        public DbSet<Vw_CategoryProduct> Vw_CategoryProducts { get; set; }
        public DbSet<Vw_Product> Vw_Product { get; set; }
    }
}
