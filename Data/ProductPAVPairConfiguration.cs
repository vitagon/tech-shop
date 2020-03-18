using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class ProductPAVPairConfiguration : IEntityTypeConfiguration<ProductPAVPair>
    {
        public void Configure(EntityTypeBuilder<ProductPAVPair> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.PAVPairId });

            builder.HasData(
                // Set RAM size
                new ProductPAVPair { ProductId = 1, PAVPairId = 2 },
                new ProductPAVPair { ProductId = 2, PAVPairId = 2 },
                new ProductPAVPair { ProductId = 3, PAVPairId = 4 },
                new ProductPAVPair { ProductId = 6, PAVPairId = 2 },
                new ProductPAVPair { ProductId = 7, PAVPairId = 3 },
                new ProductPAVPair { ProductId = 8, PAVPairId = 4 },
                new ProductPAVPair { ProductId = 9, PAVPairId = 6 },

                // Set SSD size
                new ProductPAVPair { ProductId = 1, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 2, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 3, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 6, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 7, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 8, PAVPairId = 16 },
                new ProductPAVPair { ProductId = 9, PAVPairId = 19 },

                // Set Operating System
                new ProductPAVPair { ProductId = 1, PAVPairId = 61 },
                new ProductPAVPair { ProductId = 2, PAVPairId = 61 },
                new ProductPAVPair { ProductId = 3, PAVPairId = 65 },
                new ProductPAVPair { ProductId = 6, PAVPairId = 62 },
                new ProductPAVPair { ProductId = 7, PAVPairId = 62 },
                new ProductPAVPair { ProductId = 8, PAVPairId = 62 },
                new ProductPAVPair { ProductId = 9, PAVPairId = 62 }
                );
        }
    }
}
