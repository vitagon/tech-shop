using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
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

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Lft = 1,
                        Rgt = 38,
                        Name = "Categories",
                        ParentId = 0,
                        Level = 0,
                        Url = ""
                    },
                    new Category
                    {
                        Id = 2,
                        Lft = 2,
                        Rgt = 7,
                        Name = "Computers and laptops",
                        ParentId = 1,
                        Level = 1,
                        Url = "computers-and-laptops"
                    },
                    new Category
                    {
                        Id = 3,
                        Lft = 3,
                        Rgt = 6,
                        Name = "Laptops",
                        ParentId = 2,
                        Level = 2,
                        Url = "laptops"
                    },
                    new Category
                    {
                        Id = 4,
                        Lft = 4,
                        Rgt = 5,
                        Name = "All Laptops",
                        ParentId = 3,
                        Level = 3,
                        Url = "all-laptops"
                    },
                    new Category
                    {
                        Id = 5,
                        Lft = 8,
                        Rgt = 17,
                        Name = "Photo and video",
                        ParentId = 1,
                        Level = 1,
                        Url = "photo-and-video"
                    },
                    new Category
                    {
                        Id = 6,
                        Lft = 9,
                        Rgt = 10,
                        Name = "Cameras",
                        ParentId = 5,
                        Level = 2,
                        Url = "cameras"
                    },
                    new Category
                    {
                        Id = 7,
                        Lft = 11,
                        Rgt = 16,
                        Name = "Lenses, optics, flashes",
                        ParentId = 5,
                        Level = 2,
                        Url = "lenses-optics-flashes"
                    },
                    new Category
                    {
                        Id = 8,
                        Lft = 12,
                        Rgt = 15,
                        Name = "Lenses",
                        ParentId = 7,
                        Level = 3,
                        Url = "lenses"
                    },
                    new Category
                    {
                        Id = 9,
                        Lft = 18,
                        Rgt = 27,
                        Name = "TVs, audio, video",
                        ParentId = 1,
                        Level = 1,
                        Url = "tvs-audio-video"
                    },
                    new Category
                    {
                        Id = 10,
                        Lft = 19,
                        Rgt = 26,
                        Name = "TVs",
                        ParentId = 9,
                        Level = 2,
                        Url = "tvs"
                    },
                    new Category
                    {
                        Id = 11,
                        Lft = 20,
                        Rgt = 21,
                        Name = "All TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "all-tvs"
                    },
                    new Category
                    {
                        Id = 12,
                        Lft = 22,
                        Rgt = 23,
                        Name = "Smart-TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "smart-tvs"
                    },
                    new Category
                    {
                        Id = 13,
                        Lft = 24,
                        Rgt = 25,
                        Name = "OLED TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "oled-tvs"
                    },
                    new Category
                    {
                        Id = 14,
                        Lft = 28,
                        Rgt = 37,
                        Name = "Smartphones and gadgets",
                        ParentId = 1,
                        Level = 1,
                        Url = "smartphones-and-gadgets"
                    },
                    new Category
                    {
                        Id = 15,
                        Lft = 29,
                        Rgt = 32,
                        Name = "Smartphones",
                        ParentId = 14,
                        Level = 2,
                        Url = "smartphones"
                    },
                    new Category
                    {
                        Id = 16,
                        Lft = 30,
                        Rgt = 31,
                        Name = "All Smartphones",
                        ParentId = 15,
                        Level = 3,
                        Url = "all-smartphones"
                    },
                    new Category
                    {
                        Id = 17,
                        Lft = 33,
                        Rgt = 36,
                        Name = "Tablets",
                        ParentId = 14,
                        Level = 2,
                        Url = "tablets"
                    },
                    new Category
                    {
                        Id = 18,
                        Lft = 34,
                        Rgt = 35,
                        Name = "All Tablets",
                        ParentId = 17,
                        Level = 3,
                        Url = "all-tablets"
                    });

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Laptop ASUS Air G3425",
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
                        Name = "Laptop ASUS Air G3425",
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

            DateTimeFormatInfo dateTimeFormat = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            modelBuilder.Entity<PriceHistory>().HasData(
                new PriceHistory
                {
                    Id = 1,
                    Description = "Initial",
                    ProductId = 1,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 2,
                    Description = "Initial",
                    ProductId = 2,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 3,
                    Description = "Initial",
                    ProductId = 3,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 4,
                    Description = "Initial",
                    ProductId = 4,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 5,
                    Description = "Initial",
                    ProductId = 5,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 6,
                    Description = "Initial",
                    ProductId = 6,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 7,
                    Description = "Initial",
                    ProductId = 7,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 8,
                    Description = "Initial",
                    ProductId = 8,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 9,
                    Description = "Initial",
                    ProductId = 9,
                    Price = 150m,
                    StartDate = DateTime.Parse("03/01/2020", dateTimeFormat)
                },

                // Purchase price increased, and we had to increase our prices
                new PriceHistory
                {
                    Id = 10,
                    Description = "Purchase price increased",
                    ProductId = 1,
                    Price = 167m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 11,
                    Description = "Purchase price increased",
                    ProductId = 2,
                    Price = 165m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 12,
                    Description = "Purchase price increased",
                    ProductId = 3,
                    Price = 193m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 13,
                    Description = "Purchase price increased",
                    ProductId = 4,
                    Price = 169m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 14,
                    Description = "Purchase price increased",
                    ProductId = 5,
                    Price = 156m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 15,
                    Description = "Purchase price increased",
                    ProductId = 6,
                    Price = 176m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 16,
                    Description = "Purchase price increased",
                    ProductId = 7,
                    Price = 181m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 17,
                    Description = "Purchase price increased",
                    ProductId = 8,
                    Price = 173m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                },
                new PriceHistory
                {
                    Id = 18,
                    Description = "Purchase price increased",
                    ProductId = 9,
                    Price = 165m,
                    StartDate = DateTime.Parse("03/11/2020", dateTimeFormat)
                }
                ); ;

            modelBuilder.Entity<CategoryProduct>().HasData(
                new CategoryProduct { CategoryId = 4, ProductId = 1 },
                new CategoryProduct { CategoryId = 4, ProductId = 3 },
                new CategoryProduct { CategoryId = 4, ProductId = 6 },
                new CategoryProduct { CategoryId = 4, ProductId = 7 },
                new CategoryProduct { CategoryId = 4, ProductId = 8 },
                new CategoryProduct { CategoryId = 4, ProductId = 9 },
                new CategoryProduct { CategoryId = 4, ProductId = 2 },
                new CategoryProduct { CategoryId = 18, ProductId = 4 },
                new CategoryProduct { CategoryId = 4, ProductId = 5 });

            modelBuilder.Entity<PAttribute>().HasData(
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

            modelBuilder.Entity<PValue>().HasData(
                // RAM
                new PValue { Id = 1, Value = "2 GB" },
                new PValue { Id = 2, Value = "4 GB" },
                new PValue { Id = 3, Value = "6 GB" },
                new PValue { Id = 4, Value = "8 GB" },
                new PValue { Id = 5, Value = "12 GB" },
                new PValue { Id = 6, Value = "16 GB" },
                new PValue { Id = 7, Value = "24 GB" },
                new PValue { Id = 8, Value = "32 GB" },
                new PValue { Id = 9, Value = "64 GB" },

                // HDD Size
                new PValue { Id = 10, Value = "None" },
                new PValue { Id = 11, Value = "500 GB" },
                new PValue { Id = 12, Value = "1000 GB" },
                new PValue { Id = 13, Value = "1500 GB" },
                new PValue { Id = 14, Value = "2000 GB" },
                new PValue { Id = 15, Value = "2500 GB" },

                // SSD Size
                new PValue { Id = 16, Value = "128 GB" },
                new PValue { Id = 17, Value = "180 GB" },
                new PValue { Id = 18, Value = "256 GB" },
                new PValue { Id = 19, Value = "512 GB" },
                new PValue { Id = 20, Value = "1024 GB" },

                // Display Size
                new PValue { Id = 21, Value = "11\"" },
                new PValue { Id = 22, Value = "11.6\"" },
                new PValue { Id = 23, Value = "12\"" },
                new PValue { Id = 24, Value = "12.5\"" },
                new PValue { Id = 25, Value = "13.3\"" },
                new PValue { Id = 26, Value = "14\"" },
                new PValue { Id = 27, Value = "15.6\"" },
                new PValue { Id = 28, Value = "17.3\"" },

                // Display Resolution
                new PValue { Id = 29, Value = "1366x768" },
                new PValue { Id = 30, Value = "1366x912" },
                new PValue { Id = 31, Value = "1440x900" },
                new PValue { Id = 32, Value = "1600x900" },
                new PValue { Id = 33, Value = "1920x1080" },
                new PValue { Id = 34, Value = "2160x1440" },
                new PValue { Id = 35, Value = "2304x1440" },
                new PValue { Id = 36, Value = "2560x1600" },
                new PValue { Id = 37, Value = "2880x1800" },
                new PValue { Id = 38, Value = "3000x2000" },
                new PValue { Id = 39, Value = "3072x1920" },
                new PValue { Id = 40, Value = "3200x1800" },
                new PValue { Id = 41, Value = "3840x2160" },

                // Processor Type
                new PValue { Id = 42, Value = "Intel Core i9" },
                new PValue { Id = 43, Value = "Intel Core i7" },
                new PValue { Id = 44, Value = "Intel Core i5" },
                new PValue { Id = 45, Value = "Intel Core i3" },
                new PValue { Id = 46, Value = "Intel Xeon" },
                new PValue { Id = 47, Value = "Intel Core M7" },
                new PValue { Id = 48, Value = "Intel Core M5" },
                new PValue { Id = 49, Value = "Intel Core M3" },
                new PValue { Id = 50, Value = "Intel Pentium" },
                new PValue { Id = 51, Value = "Intel Celeron" },
                new PValue { Id = 52, Value = "Intel Atom" },
                new PValue { Id = 53, Value = "AMD Razen 7" },
                new PValue { Id = 54, Value = "AMD Razen 5" },
                new PValue { Id = 55, Value = "AMD Razen 3" },
                new PValue { Id = 56, Value = "AMD A9" },

                // Number of CPU Cores
                new PValue { Id = 57, Value = "2" },
                new PValue { Id = 58, Value = "4" },
                new PValue { Id = 59, Value = "6" },
                new PValue { Id = 60, Value = "8" },

                // Operating System
                new PValue { Id = 61, Value = "Windows 10 Home" },
                new PValue { Id = 62, Value = "Windows 10 Professional" },
                new PValue { Id = 63, Value = "UNIX" },
                new PValue { Id = 64, Value = "Chrome OS" },
                new PValue { Id = 65, Value = "MacOS" },

                // Graphics Type
                new PValue { Id = 66, Value = "Integrated" },
                new PValue { Id = 67, Value = "Dedicated & Integrated" },

                // Graphics Processor
                new PValue { Id = 68, Value = "GeForce RTX 2080" },
                new PValue { Id = 69, Value = "GeForce RTX 2080 MaxQ" },
                new PValue { Id = 70, Value = "GeForce RTX 2070" },
                new PValue { Id = 71, Value = "GeForce RTX 2070 MaxQ" },
                new PValue { Id = 72, Value = "Radeon 540X" },
                new PValue { Id = 73, Value = "GeForce MX250" },
                new PValue { Id = 74, Value = "GeForce MX230" },

                // Graphics Brand
                new PValue { Id = 75, Value = "AMD" },
                new PValue { Id = 76, Value = "Intel" },
                new PValue { Id = 77, Value = "nVidia" }
                );

            modelBuilder.Entity<PAVPair>().HasData(
                // RAM
                new PAVPair { Id = 1, AttributeId = 1, ValueId = 1 },
                new PAVPair { Id = 2, AttributeId = 1, ValueId = 2 },
                new PAVPair { Id = 3, AttributeId = 1, ValueId = 3 },
                new PAVPair { Id = 4, AttributeId = 1, ValueId = 4 },
                new PAVPair { Id = 5, AttributeId = 1, ValueId = 5 },
                new PAVPair { Id = 6, AttributeId = 1, ValueId = 6 },
                new PAVPair { Id = 7, AttributeId = 1, ValueId = 7 },
                new PAVPair { Id = 8, AttributeId = 1, ValueId = 8 },
                new PAVPair { Id = 9, AttributeId = 1, ValueId = 9 },

                // HDD Size
                new PAVPair { Id = 10, AttributeId = 2, ValueId = 10 },
                new PAVPair { Id = 11, AttributeId = 2, ValueId = 11 },
                new PAVPair { Id = 12, AttributeId = 2, ValueId = 12 },
                new PAVPair { Id = 13, AttributeId = 2, ValueId = 13 },
                new PAVPair { Id = 14, AttributeId = 2, ValueId = 14 },
                new PAVPair { Id = 15, AttributeId = 2, ValueId = 15 },

                // SSD Size
                new PAVPair { Id = 16, AttributeId = 3, ValueId = 16 },
                new PAVPair { Id = 17, AttributeId = 3, ValueId = 17 },
                new PAVPair { Id = 18, AttributeId = 3, ValueId = 18 },
                new PAVPair { Id = 19, AttributeId = 3, ValueId = 19 },
                new PAVPair { Id = 20, AttributeId = 3, ValueId = 20 },

                // Display Size
                new PAVPair { Id = 21, AttributeId = 4, ValueId = 21 },
                new PAVPair { Id = 22, AttributeId = 4, ValueId = 22 },
                new PAVPair { Id = 23, AttributeId = 4, ValueId = 23 },
                new PAVPair { Id = 24, AttributeId = 4, ValueId = 24 },
                new PAVPair { Id = 25, AttributeId = 4, ValueId = 25 },
                new PAVPair { Id = 26, AttributeId = 4, ValueId = 26 },
                new PAVPair { Id = 27, AttributeId = 4, ValueId = 27 },
                new PAVPair { Id = 28, AttributeId = 4, ValueId = 28 },

                // Display Resolution
                new PAVPair { Id = 29, AttributeId = 5, ValueId = 29 },
                new PAVPair { Id = 30, AttributeId = 5, ValueId = 30 },
                new PAVPair { Id = 31, AttributeId = 5, ValueId = 31 },
                new PAVPair { Id = 32, AttributeId = 5, ValueId = 32 },
                new PAVPair { Id = 33, AttributeId = 5, ValueId = 33 },
                new PAVPair { Id = 34, AttributeId = 5, ValueId = 34 },
                new PAVPair { Id = 35, AttributeId = 5, ValueId = 35 },
                new PAVPair { Id = 36, AttributeId = 5, ValueId = 36 },
                new PAVPair { Id = 37, AttributeId = 5, ValueId = 37 },
                new PAVPair { Id = 38, AttributeId = 5, ValueId = 38 },
                new PAVPair { Id = 39, AttributeId = 5, ValueId = 39 },
                new PAVPair { Id = 40, AttributeId = 5, ValueId = 40 },
                new PAVPair { Id = 41, AttributeId = 5, ValueId = 41 },

                // Processor Type
                new PAVPair { Id = 42, AttributeId = 6, ValueId = 42 },
                new PAVPair { Id = 43, AttributeId = 6, ValueId = 43 },
                new PAVPair { Id = 44, AttributeId = 6, ValueId = 44 },
                new PAVPair { Id = 45, AttributeId = 6, ValueId = 45 },
                new PAVPair { Id = 46, AttributeId = 6, ValueId = 46 },
                new PAVPair { Id = 47, AttributeId = 6, ValueId = 47 },
                new PAVPair { Id = 48, AttributeId = 6, ValueId = 48 },
                new PAVPair { Id = 49, AttributeId = 6, ValueId = 49 },
                new PAVPair { Id = 50, AttributeId = 6, ValueId = 50 },
                new PAVPair { Id = 51, AttributeId = 6, ValueId = 51 },
                new PAVPair { Id = 52, AttributeId = 6, ValueId = 52 },
                new PAVPair { Id = 53, AttributeId = 6, ValueId = 53 },
                new PAVPair { Id = 54, AttributeId = 6, ValueId = 54 },
                new PAVPair { Id = 55, AttributeId = 6, ValueId = 55 },
                new PAVPair { Id = 56, AttributeId = 6, ValueId = 56 },

                // Number of CPU Cores
                new PAVPair { Id = 57, AttributeId = 7, ValueId = 57 },
                new PAVPair { Id = 58, AttributeId = 7, ValueId = 58 },
                new PAVPair { Id = 59, AttributeId = 7, ValueId = 59 },
                new PAVPair { Id = 60, AttributeId = 7, ValueId = 60 },

                // Operating System
                new PAVPair { Id = 61, AttributeId = 8, ValueId = 61 },
                new PAVPair { Id = 62, AttributeId = 8, ValueId = 62 },
                new PAVPair { Id = 63, AttributeId = 8, ValueId = 63 },
                new PAVPair { Id = 64, AttributeId = 8, ValueId = 64 },
                new PAVPair { Id = 65, AttributeId = 8, ValueId = 65 },

                // Graphics Type
                new PAVPair { Id = 66, AttributeId = 9, ValueId = 66 },
                new PAVPair { Id = 67, AttributeId = 9, ValueId = 67 },

                // Graphics Processor
                new PAVPair { Id = 68, AttributeId = 10, ValueId = 68 },
                new PAVPair { Id = 69, AttributeId = 10, ValueId = 69 },
                new PAVPair { Id = 70, AttributeId = 10, ValueId = 70 },
                new PAVPair { Id = 71, AttributeId = 10, ValueId = 71 },
                new PAVPair { Id = 72, AttributeId = 10, ValueId = 72 },
                new PAVPair { Id = 73, AttributeId = 10, ValueId = 73 },
                new PAVPair { Id = 74, AttributeId = 10, ValueId = 74 },

                // Graphics Brand
                new PAVPair { Id = 75, AttributeId = 11, ValueId = 75 },
                new PAVPair { Id = 76, AttributeId = 11, ValueId = 76 },
                new PAVPair { Id = 77, AttributeId = 11, ValueId = 77 }
                );

            modelBuilder.Entity<ProductPAVPair>().HasData(
                // Set RAM size
                new ProductPAVPair { ProductId = 1, AVPairId = 2 },
                new ProductPAVPair { ProductId = 2, AVPairId = 2 },
                new ProductPAVPair { ProductId = 3, AVPairId = 4 },
                new ProductPAVPair { ProductId = 6, AVPairId = 2 },
                new ProductPAVPair { ProductId = 7, AVPairId = 3 },
                new ProductPAVPair { ProductId = 8, AVPairId = 4 },
                new ProductPAVPair { ProductId = 9, AVPairId = 6 },

                // Set SSD size
                new ProductPAVPair { ProductId = 1, AVPairId = 16 },
                new ProductPAVPair { ProductId = 2, AVPairId = 16 },
                new ProductPAVPair { ProductId = 3, AVPairId = 16 },
                new ProductPAVPair { ProductId = 6, AVPairId = 16 },
                new ProductPAVPair { ProductId = 7, AVPairId = 16 },
                new ProductPAVPair { ProductId = 8, AVPairId = 16 },
                new ProductPAVPair { ProductId = 9, AVPairId = 19 },

                // Set Operating System
                new ProductPAVPair { ProductId = 1, AVPairId = 61 },
                new ProductPAVPair { ProductId = 2, AVPairId = 61 },
                new ProductPAVPair { ProductId = 3, AVPairId = 65 },
                new ProductPAVPair { ProductId = 6, AVPairId = 62 },
                new ProductPAVPair { ProductId = 7, AVPairId = 62 },
                new ProductPAVPair { ProductId = 8, AVPairId = 62 },
                new ProductPAVPair { ProductId = 9, AVPairId = 62 }
                );

            modelBuilder.Entity<PFilterName>().HasData(
                new PFilterName { Id = 1, FilterName = "RAM Size" },
                new PFilterName { Id = 2, FilterName = "SSD size" },
                new PFilterName { Id = 3, FilterName = "Operating System" }
                );

            modelBuilder.Entity<PFilterValue>().HasData(
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

            modelBuilder.Entity<PFilter>().HasData(
                // RAM Filter
                new PFilter { Id = 1, PFilterNameId = 1, PFilterValueId = 1 },
                new PFilter { Id = 2, PFilterNameId = 1, PFilterValueId = 2 },
                new PFilter { Id = 3, PFilterNameId = 1, PFilterValueId = 3 },
                new PFilter { Id = 4, PFilterNameId = 1, PFilterValueId = 4 },
                new PFilter { Id = 5, PFilterNameId = 1, PFilterValueId = 5 },
                new PFilter { Id = 6, PFilterNameId = 1, PFilterValueId = 6 },

                // SSD Size Filter
                new PFilter { Id = 7, PFilterNameId = 2, PFilterValueId = 7 },
                new PFilter { Id = 8, PFilterNameId = 2, PFilterValueId = 8 },
                new PFilter { Id = 9, PFilterNameId = 2, PFilterValueId = 9 },

                // Operating System Filter
                new PFilter { Id = 10, PFilterNameId = 3, PFilterValueId = 10 },
                new PFilter { Id = 11, PFilterNameId = 3, PFilterValueId = 11 },
                new PFilter { Id = 12, PFilterNameId = 3, PFilterValueId = 12 }
                );

            modelBuilder.Entity<PFilterPAVPair>().HasData(
                // RAM
                new PFilterPAVPair { FilterId = 1, AVPairId = 1 },
                new PFilterPAVPair { FilterId = 2, AVPairId = 2 },
                new PFilterPAVPair { FilterId = 3, AVPairId = 3 },
                new PFilterPAVPair { FilterId = 4, AVPairId = 4 },
                new PFilterPAVPair { FilterId = 5, AVPairId = 5 },
                new PFilterPAVPair { FilterId = 6, AVPairId = 6 },

                // SSD 128 to 256 GB
                new PFilterPAVPair { FilterId = 7, AVPairId = 16 },
                new PFilterPAVPair { FilterId = 7, AVPairId = 17 },
                new PFilterPAVPair { FilterId = 7, AVPairId = 18 },

                // SSD (257 to 512 GB) (513 to 1024 GB)
                new PFilterPAVPair { FilterId = 8, AVPairId = 19 },
                new PFilterPAVPair { FilterId = 9, AVPairId = 20 },

                // Operating System (Windows -> Windows Home, Windows Professional)
                new PFilterPAVPair { FilterId = 10, AVPairId = 61 },
                new PFilterPAVPair { FilterId = 10, AVPairId = 62 },

                // Operating System (MacOS and UNIX)
                new PFilterPAVPair { FilterId = 11, AVPairId = 65 },
                new PFilterPAVPair { FilterId = 12, AVPairId = 63 }
                );
        }
    }
}
