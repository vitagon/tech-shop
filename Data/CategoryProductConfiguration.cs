using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class CategoryProductConfiguration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(table => new { table.CategoryId, table.ProductId });

            builder.HasData(
                new CategoryProduct { CategoryId = 4, ProductId = 1 },
                new CategoryProduct { CategoryId = 4, ProductId = 3 },
                new CategoryProduct { CategoryId = 4, ProductId = 6 },
                new CategoryProduct { CategoryId = 4, ProductId = 7 },
                new CategoryProduct { CategoryId = 4, ProductId = 8 },
                new CategoryProduct { CategoryId = 4, ProductId = 9 },
                new CategoryProduct { CategoryId = 4, ProductId = 2 },
                new CategoryProduct { CategoryId = 18, ProductId = 4 }
                );
        }
    }
}
