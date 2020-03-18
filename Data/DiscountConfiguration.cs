using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            DateTimeFormatInfo dateTimeFormat = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            builder.HasData(
                new Discount
                {
                    Id = 1,
                    Description = "New Year Sale",
                    StartDate = DateTime.Parse("01/01/2020", dateTimeFormat),
                    EndDate = DateTime.Parse("01/31/2020", dateTimeFormat),
                    Rate = 15m
                },
                new Discount
                {
                    Id = 2,
                    Description = "First Year of Shop Opening",
                    StartDate = DateTime.Parse("01/01/2020", dateTimeFormat),
                    EndDate = DateTime.Parse("12/31/2020", dateTimeFormat),
                    Rate = 5m
                }, new Discount
                {
                    Id = 3,
                    Description = "Special Laptops Sale",
                    StartDate = DateTime.Parse("01/01/2020", dateTimeFormat),
                    EndDate = DateTime.Parse("12/31/2020", dateTimeFormat),
                    Rate = 5m
                });
        }
    }
}
