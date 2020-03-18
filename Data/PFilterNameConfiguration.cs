using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PFilterNameConfiguration : IEntityTypeConfiguration<PFilterName>
    {
        public void Configure(EntityTypeBuilder<PFilterName> builder)
        {
            builder.HasIndex(x => x.FilterName).IsUnique();

            builder.HasData(
                new PFilterName { Id = 1, FilterName = "RAM Size" },
                new PFilterName { Id = 2, FilterName = "SSD size" },
                new PFilterName { Id = 3, FilterName = "Operating System" }
                );
        }
    }
}
