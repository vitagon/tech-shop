using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Laptop ASUS Air G3425 Black",
                        Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]",
                        Img = "/img/product01.png",
                        BrandId = 1,
                        Rating = 5
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Laptop Lenovo C1124",
                        Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]",
                        Img = "/img/product01.png",
                        BrandId = 6,
                        Rating = 0
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Laptop Mackbook Air 2",
                        Description = "[i5, 1.8/8Gb/128SSD, (MQD32RU/A)]",
                        Img = "/img/product03.png",
                        BrandId = 3,
                        Rating = 3
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Tablet Sony Z3",
                        Description = "[1920x1200, IPS, 8х2.36 GGz, 3 GB, BT, GPS, 5100 mAh, Android 8.x+]",
                        Img = "/img/product04.png",
                        BrandId = 8,
                        Rating = 4
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Headphones Epson GT23",
                        Description = "[5.1, Closed-Back, 20 Gz - 25000 Gz, 35Ω, wired, cable - 2 m, black]",
                        Img = "/img/product05.png",
                        BrandId = 7,
                        Rating = 5
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Laptop Acer H2451",
                        Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Professional]",
                        Img = "/img/product06.png",
                        BrandId = 2,
                        Rating = 4
                    },
                    new Product
                    {
                        Id = 7,
                        Name = "Laptop ASUS Air G3425 Grey",
                        Description = "[Intel Celeron J4005, 2x2000 MGz, 6 GB DDR3, SSD 128 GB, Windows 10 Professional]",
                        Img = "/img/product07.png",
                        BrandId = 1,
                        Rating = 1
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Laptop ASUS Air G5161",
                        Description = "[Intel Celeron J4005, 2x4000 MGz, 8 GB DDR3, SSD 128 GB, Windows 10 Professional]",
                        Img = "/img/product08.png",
                        BrandId = 1,
                        Rating = 2
                    },
                    new Product
                    {
                        Id = 9,
                        Name = "Laptop ASUS Air G9515",
                        Description = "[Intel Celeron J4005, 2x2000 MGz, 16 GB DDR3, SSD 512 GB, Windows 10 Professional]",
                        Img = "/img/product09.png",
                        BrandId = 1,
                        Rating = 3
                    }
                );
        }
    }
}
