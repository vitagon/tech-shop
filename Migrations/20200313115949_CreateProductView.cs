using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateProductView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
				CREATE VIEW vw_Product
				AS
                SELECT p.Id, p.[Name], p.[Description], p.Img, b.Id as BrandId, b.[Name] as BrandName, p.Rating,
				ph.Id as PriceId, ph.[Description] AS PriceDescription, ph.StartDate AS PriceStartDate, d.Id as DiscountId, d.StartDate AS DiscountStartDate, d.EndDate AS DiscountEndDate, d.Rate AS DiscountRate,
				IIF(d.Rate IS NOT NULL, ROUND(CAST((ph.Price * d.Rate / 100) as decimal(18,2)), 2), ph.Price) AS Price, IIF(d.Rate IS NOT NULL, ph.Price, NULL) AS OldPrice
				FROM Product p
				JOIN Brand b ON p.BrandId = b.Id
				JOIN
					(
						select
							Id, [Description], Price, ProductId, MAX(StartDate) as StartDate
						from PriceHistory
						group by ProductId, Id, [Description], StartDate, Price
					) ph
					ON p.Id = ph.ProductId
				LEFT JOIN
					(
						select
							Id, [Description], ProductId, Rate, StartDate, EndDate
						from Discount
						where StartDate <= CURRENT_TIMESTAMP and EndDate > CURRENT_TIMESTAMP
						group by ProductId, Id, [Description], Rate, StartDate, EndDate
					) d
					ON d.ProductId = ph.ProductId;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION vw_Product");
        }
    }
}
