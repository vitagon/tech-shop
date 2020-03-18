using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PAttributeConfiguration : IEntityTypeConfiguration<PAttribute>
    {
        public void Configure(EntityTypeBuilder<PAttribute> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasData(
                new PAttribute { Id = 1, Name = "RAM" },
                new PAttribute { Id = 2, Name = "HDD Size" },
                new PAttribute { Id = 3, Name = "SSD Size" },
                new PAttribute { Id = 4, Name = "Display Size" },
                new PAttribute { Id = 5, Name = "Display Resolution" },
                new PAttribute { Id = 6, Name = "Processor Type" },
                new PAttribute { Id = 7, Name = "Number of CPU Cores" },
                new PAttribute { Id = 8, Name = "Operating System" },
                new PAttribute { Id = 9, Name = "Graphics Type" },
                new PAttribute { Id = 10, Name = "Graphics Processor" },
                new PAttribute { Id = 11, Name = "Graphics Brand" }
                );
        }
    }
}
