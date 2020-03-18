using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PFilterValueConfiguration : IEntityTypeConfiguration<PFilterValue>
    {
        public void Configure(EntityTypeBuilder<PFilterValue> builder)
        {
            builder.HasIndex(x => x.FilterValue).IsUnique();

            builder.HasData(
                // RAM Filter Values
                new PFilterValue { Id = 1, FilterValue = "2 GB" },
                new PFilterValue { Id = 2, FilterValue = "4 GB" },
                new PFilterValue { Id = 3, FilterValue = "6 GB" },
                new PFilterValue { Id = 4, FilterValue = "8 GB" },
                new PFilterValue { Id = 5, FilterValue = "12 GB" },
                new PFilterValue { Id = 6, FilterValue = "16 GB" },

                // SSD Size Filter Values
                new PFilterValue { Id = 7, FilterValue = "128 to 256 GB" },
                new PFilterValue { Id = 8, FilterValue = "257 to 512 GB" },
                new PFilterValue { Id = 9, FilterValue = "513 to 1024 GB" },

                // Operating System Filter Values
                new PFilterValue { Id = 10, FilterValue = "Windows" },
                new PFilterValue { Id = 11, FilterValue = "MacOS" },
                new PFilterValue { Id = 12, FilterValue = "Unix" }
                );
        }
    }
}
