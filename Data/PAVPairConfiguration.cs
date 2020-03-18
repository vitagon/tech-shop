using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PAVPairConfiguration : IEntityTypeConfiguration<PAVPair>
    {
        public void Configure(EntityTypeBuilder<PAVPair> builder)
        {
            builder.HasIndex(x => new { x.PAttributeId, x.PValueId }).IsUnique();

            builder.HasData(
                // RAM
                new PAVPair { Id = 1, PAttributeId = 1, PValueId = 1 },
                new PAVPair { Id = 2, PAttributeId = 1, PValueId = 2 },
                new PAVPair { Id = 3, PAttributeId = 1, PValueId = 3 },
                new PAVPair { Id = 4, PAttributeId = 1, PValueId = 4 },
                new PAVPair { Id = 5, PAttributeId = 1, PValueId = 5 },
                new PAVPair { Id = 6, PAttributeId = 1, PValueId = 6 },
                new PAVPair { Id = 7, PAttributeId = 1, PValueId = 7 },
                new PAVPair { Id = 8, PAttributeId = 1, PValueId = 8 },
                new PAVPair { Id = 9, PAttributeId = 1, PValueId = 9 },

                // HDD Size
                new PAVPair { Id = 10, PAttributeId = 2, PValueId = 10 },
                new PAVPair { Id = 11, PAttributeId = 2, PValueId = 11 },
                new PAVPair { Id = 12, PAttributeId = 2, PValueId = 12 },
                new PAVPair { Id = 13, PAttributeId = 2, PValueId = 13 },
                new PAVPair { Id = 14, PAttributeId = 2, PValueId = 14 },
                new PAVPair { Id = 15, PAttributeId = 2, PValueId = 15 },

                // SSD Size
                new PAVPair { Id = 16, PAttributeId = 3, PValueId = 16 },
                new PAVPair { Id = 17, PAttributeId = 3, PValueId = 17 },
                new PAVPair { Id = 18, PAttributeId = 3, PValueId = 18 },
                new PAVPair { Id = 19, PAttributeId = 3, PValueId = 19 },
                new PAVPair { Id = 20, PAttributeId = 3, PValueId = 20 },

                // Display Size
                new PAVPair { Id = 21, PAttributeId = 4, PValueId = 21 },
                new PAVPair { Id = 22, PAttributeId = 4, PValueId = 22 },
                new PAVPair { Id = 23, PAttributeId = 4, PValueId = 23 },
                new PAVPair { Id = 24, PAttributeId = 4, PValueId = 24 },
                new PAVPair { Id = 25, PAttributeId = 4, PValueId = 25 },
                new PAVPair { Id = 26, PAttributeId = 4, PValueId = 26 },
                new PAVPair { Id = 27, PAttributeId = 4, PValueId = 27 },
                new PAVPair { Id = 28, PAttributeId = 4, PValueId = 28 },

                // Display Resolution
                new PAVPair { Id = 29, PAttributeId = 5, PValueId = 29 },
                new PAVPair { Id = 30, PAttributeId = 5, PValueId = 30 },
                new PAVPair { Id = 31, PAttributeId = 5, PValueId = 31 },
                new PAVPair { Id = 32, PAttributeId = 5, PValueId = 32 },
                new PAVPair { Id = 33, PAttributeId = 5, PValueId = 33 },
                new PAVPair { Id = 34, PAttributeId = 5, PValueId = 34 },
                new PAVPair { Id = 35, PAttributeId = 5, PValueId = 35 },
                new PAVPair { Id = 36, PAttributeId = 5, PValueId = 36 },
                new PAVPair { Id = 37, PAttributeId = 5, PValueId = 37 },
                new PAVPair { Id = 38, PAttributeId = 5, PValueId = 38 },
                new PAVPair { Id = 39, PAttributeId = 5, PValueId = 39 },
                new PAVPair { Id = 40, PAttributeId = 5, PValueId = 40 },
                new PAVPair { Id = 41, PAttributeId = 5, PValueId = 41 },

                // Processor Type
                new PAVPair { Id = 42, PAttributeId = 6, PValueId = 42 },
                new PAVPair { Id = 43, PAttributeId = 6, PValueId = 43 },
                new PAVPair { Id = 44, PAttributeId = 6, PValueId = 44 },
                new PAVPair { Id = 45, PAttributeId = 6, PValueId = 45 },
                new PAVPair { Id = 46, PAttributeId = 6, PValueId = 46 },
                new PAVPair { Id = 47, PAttributeId = 6, PValueId = 47 },
                new PAVPair { Id = 48, PAttributeId = 6, PValueId = 48 },
                new PAVPair { Id = 49, PAttributeId = 6, PValueId = 49 },
                new PAVPair { Id = 50, PAttributeId = 6, PValueId = 50 },
                new PAVPair { Id = 51, PAttributeId = 6, PValueId = 51 },
                new PAVPair { Id = 52, PAttributeId = 6, PValueId = 52 },
                new PAVPair { Id = 53, PAttributeId = 6, PValueId = 53 },
                new PAVPair { Id = 54, PAttributeId = 6, PValueId = 54 },
                new PAVPair { Id = 55, PAttributeId = 6, PValueId = 55 },
                new PAVPair { Id = 56, PAttributeId = 6, PValueId = 56 },

                // Number of CPU Cores
                new PAVPair { Id = 57, PAttributeId = 7, PValueId = 57 },
                new PAVPair { Id = 58, PAttributeId = 7, PValueId = 58 },
                new PAVPair { Id = 59, PAttributeId = 7, PValueId = 59 },
                new PAVPair { Id = 60, PAttributeId = 7, PValueId = 60 },

                // Operating System
                new PAVPair { Id = 61, PAttributeId = 8, PValueId = 61 },
                new PAVPair { Id = 62, PAttributeId = 8, PValueId = 62 },
                new PAVPair { Id = 63, PAttributeId = 8, PValueId = 63 },
                new PAVPair { Id = 64, PAttributeId = 8, PValueId = 64 },
                new PAVPair { Id = 65, PAttributeId = 8, PValueId = 65 },

                // Graphics Type
                new PAVPair { Id = 66, PAttributeId = 9, PValueId = 66 },
                new PAVPair { Id = 67, PAttributeId = 9, PValueId = 67 },

                // Graphics Processor
                new PAVPair { Id = 68, PAttributeId = 10, PValueId = 68 },
                new PAVPair { Id = 69, PAttributeId = 10, PValueId = 69 },
                new PAVPair { Id = 70, PAttributeId = 10, PValueId = 70 },
                new PAVPair { Id = 71, PAttributeId = 10, PValueId = 71 },
                new PAVPair { Id = 72, PAttributeId = 10, PValueId = 72 },
                new PAVPair { Id = 73, PAttributeId = 10, PValueId = 73 },
                new PAVPair { Id = 74, PAttributeId = 10, PValueId = 74 },

                // Graphics Brand
                new PAVPair { Id = 75, PAttributeId = 11, PValueId = 75 },
                new PAVPair { Id = 76, PAttributeId = 11, PValueId = 76 },
                new PAVPair { Id = 77, PAttributeId = 11, PValueId = 77 }
                );
        }
    }
}
