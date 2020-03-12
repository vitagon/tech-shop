using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Brand>().HasData(
            //    new Brand { Id = 1, Name = "Asus" },
            //    new Brand { Id = 2, Name = "Acer" },
            //    new Brand { Id = 3, Name = "Apple" },
            //    new Brand { Id = 4, Name = "Dell" },
            //    new Brand { Id = 5, Name = "HP" },
            //    new Brand { Id = 6, Name = "Lenovo" },
            //    new Brand { Id = 7, Name = "Epson" },
            //    new Brand { Id = 8, Name = "Sony" },
            //    new Brand { Id = 9, Name = "Samsung" }
            //);

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

            //modelBuilder.Entity<Product>().HasData(
            //        new Product
            //        {
            //            Id = 1,
            //            Name = "Laptop ASUS Air G3425",
            //            Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]",
            //            Img = "/img/product01.png",
            //            BrandId = 1,
            //            Rating = 5
            //        },
            //        new Product
            //        {
            //            Id = 2,
            //            Name = "Headphones Lenovo C1124",
            //            Description = "[7.1, Closed-Back, 20 Gz - 20000 Gz, 35Ω, wired, cable - 2 m, black]",
            //            Img = "/img/product02.png",
            //            BrandId = 6,
            //            Rating = 0
            //        },
            //        new Product
            //        {
            //            Id = 3,
            //            Name = "Laptop Mackbook Air 2",
            //            Description = "[i5, 1.8/8Gb/128SSD, (MQD32RU/A)]",
            //            Img = "/img/product03.png",
            //            BrandId = 3,
            //            Rating = 3
            //        },
            //        new Product
            //        {
            //            Id = 4,
            //            Name = "Tablet Sony Z3",
            //            Description = "[1920x1200, IPS, 8х2.36 GGz, 3 GB, BT, GPS, 5100 mAh, Android 8.x+]",
            //            Img = "/img/product04.png",
            //            BrandId = 8,
            //            Rating = 4
            //        },
            //        new Product
            //        {
            //            Id = 5,
            //            Name = "Headphones Epson GT23",
            //            Description = "[5.1, Closed-Back, 20 Gz - 25000 Gz, 35Ω, wired, cable - 2 m, black]",
            //            Img = "/img/product05.png",
            //            BrandId = 7,
            //            Rating = 5
            //        },
            //        new Product
            //        {
            //            Id = 6,
            //            Name = "Laptop Acer H2451",
            //            Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]",
            //            Img = "/img/product06.png",
            //            BrandId = 2,
            //            Rating = 4
            //        },
            //        new Product
            //        {
            //            Id = 7,
            //            Name = "Laptop ASUS Air G3425",
            //            Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]",
            //            Img = "/img/product07.png",
            //            BrandId = 1,
            //            Rating = 1
            //        },
            //        new Product
            //        {
            //            Id = 8,
            //            Name = "Laptop ASUS Air G5161",
            //            Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]",
            //            Img = "/img/product08.png",
            //            BrandId = 1,
            //            Rating = 2
            //        },
            //        new Product
            //        {
            //            Id = 9,
            //            Name = "Laptop ASUS Air G9515",
            //            Description = "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]",
            //            Img = "/img/product09.png",
            //            BrandId = 1,
            //            Rating = 3
            //        }
            //    );

            //modelBuilder.Entity<CategoryProduct>().HasData(
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 1
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 3
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 6
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 7
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 8
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 9
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 18,
            //        ProductId = 2
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 18,
            //        ProductId = 4
            //    },
            //    new CategoryProduct
            //    {
            //        CategoryId = 4,
            //        ProductId = 5
            //    });
        }
    }
}
