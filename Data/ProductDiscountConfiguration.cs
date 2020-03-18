using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class ProductDiscountConfiguration : IEntityTypeConfiguration<ProductDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductDiscount> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.DiscountId });

            builder.HasData(
                // New Year Sale for all products
                new ProductDiscount { ProductId = 1, DiscountId = 1 },
                new ProductDiscount { ProductId = 2, DiscountId = 1 },
                new ProductDiscount { ProductId = 3, DiscountId = 1 },
                new ProductDiscount { ProductId = 4, DiscountId = 1 },
                new ProductDiscount { ProductId = 5, DiscountId = 1 },
                new ProductDiscount { ProductId = 6, DiscountId = 1 },
                new ProductDiscount { ProductId = 7, DiscountId = 1 },
                new ProductDiscount { ProductId = 8, DiscountId = 1 },
                new ProductDiscount { ProductId = 9, DiscountId = 1 },

                // Opening Sale for all products
                new ProductDiscount { ProductId = 1, DiscountId = 2 },
                new ProductDiscount { ProductId = 2, DiscountId = 2 },
                new ProductDiscount { ProductId = 3, DiscountId = 2 },
                new ProductDiscount { ProductId = 4, DiscountId = 2 },
                new ProductDiscount { ProductId = 5, DiscountId = 2 },
                new ProductDiscount { ProductId = 6, DiscountId = 2 },
                new ProductDiscount { ProductId = 7, DiscountId = 2 },
                new ProductDiscount { ProductId = 8, DiscountId = 2 },
                new ProductDiscount { ProductId = 9, DiscountId = 2 },

                // Special Laptops Sale
                new ProductDiscount { ProductId = 1, DiscountId = 3 },
                new ProductDiscount { ProductId = 2, DiscountId = 3 },
                new ProductDiscount { ProductId = 3, DiscountId = 3 },
                new ProductDiscount { ProductId = 6, DiscountId = 3 },
                new ProductDiscount { ProductId = 7, DiscountId = 3 },
                new ProductDiscount { ProductId = 8, DiscountId = 3 },
                new ProductDiscount { ProductId = 9, DiscountId = 3 }
                );
        }
    }
}
