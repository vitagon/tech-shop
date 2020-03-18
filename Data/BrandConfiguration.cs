using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasData(
                new Brand { Id = 1, Name = "Asus" },
                new Brand { Id = 2, Name = "Acer" },
                new Brand { Id = 3, Name = "Apple" },
                new Brand { Id = 4, Name = "Dell" },
                new Brand { Id = 5, Name = "HP" },
                new Brand { Id = 6, Name = "Lenovo" },
                new Brand { Id = 7, Name = "Epson" },
                new Brand { Id = 8, Name = "Sony" },
                new Brand { Id = 9, Name = "Samsung" }
            );
        }
    }
}
