using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasIndex(x => x.Url).IsUnique();

            builder.HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Categories",
                        ParentId = null,
                        Level = 0,
                        Url = ""
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Computers and laptops",
                        ParentId = 1,
                        Level = 1,
                        Url = "computers-and-laptops"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Laptops",
                        ParentId = 2,
                        Level = 2,
                        Url = "laptops"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "All Laptops",
                        ParentId = 3,
                        Level = 3,
                        Url = "all-laptops"
                    },
                    new Category
                    {
                        Id = 5,
                        Name = "Photo and video",
                        ParentId = 1,
                        Level = 1,
                        Url = "photo-and-video"
                    },
                    new Category
                    {
                        Id = 6,
                        Name = "Cameras",
                        ParentId = 5,
                        Level = 2,
                        Url = "cameras"
                    },
                    new Category
                    {
                        Id = 7,
                        Name = "Lenses, optics, flashes",
                        ParentId = 5,
                        Level = 2,
                        Url = "lenses-optics-flashes"
                    },
                    new Category
                    {
                        Id = 8,
                        Name = "Lenses",
                        ParentId = 7,
                        Level = 3,
                        Url = "lenses"
                    },
                    new Category
                    {
                        Id = 9,
                        Name = "TVs, audio, video",
                        ParentId = 1,
                        Level = 1,
                        Url = "tvs-audio-video"
                    },
                    new Category
                    {
                        Id = 10,
                        Name = "TVs",
                        ParentId = 9,
                        Level = 2,
                        Url = "tvs"
                    },
                    new Category
                    {
                        Id = 11,
                        Name = "All TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "all-tvs"
                    },
                    new Category
                    {
                        Id = 12,
                        Name = "Smart-TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "smart-tvs"
                    },
                    new Category
                    {
                        Id = 13,
                        Name = "OLED TVs",
                        ParentId = 10,
                        Level = 3,
                        Url = "oled-tvs"
                    },
                    new Category
                    {
                        Id = 14,
                        Name = "Smartphones and gadgets",
                        ParentId = 1,
                        Level = 1,
                        Url = "smartphones-and-gadgets"
                    },
                    new Category
                    {
                        Id = 15,
                        Name = "Smartphones",
                        ParentId = 14,
                        Level = 2,
                        Url = "smartphones"
                    },
                    new Category
                    {
                        Id = 16,
                        Name = "All Smartphones",
                        ParentId = 15,
                        Level = 3,
                        Url = "all-smartphones"
                    },
                    new Category
                    {
                        Id = 17,
                        Name = "Tablets",
                        ParentId = 14,
                        Level = 2,
                        Url = "tablets"
                    },
                    new Category
                    {
                        Id = 18,
                        Name = "All Tablets",
                        ParentId = 17,
                        Level = 3,
                        Url = "all-tablets"
                    });
        }
    }
}
