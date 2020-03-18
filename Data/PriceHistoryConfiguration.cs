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
    public class PriceHistoryConfiguration : IEntityTypeConfiguration<PriceHistory>
    {
        public void Configure(EntityTypeBuilder<PriceHistory> builder)
        {
            DateTimeFormatInfo dateTimeFormat = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            builder.HasData(
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
        }
    }
}
