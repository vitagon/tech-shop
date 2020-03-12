using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateCategoryProductsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql(@"
            //    CREATE VIEW vw_CategoryProducts
            //    AS
            //    SELECT
	           //     p.Id, p.[Name], p.[Description], p.Img, p.Rating, b.Name as Brand, d.Rate as Discount,
            //        IIF(, ph.Price, "") as Price,
            //        IIF(ph.Price * d.Rate / 100) as OldPrice,
	           //     c.Id as CatId, c.Lft, c.Rgt, c.[Name] as CatName, c.ParentId, c.[Level], c.[Url] as CatUrl
            //    FROM
	           //     Product p
            //    JOIN CategoryProduct cp ON p.Id = cp.ProductId
            //    JOIN Category c ON cp.CategoryId = c.Id
            //    JOIN PriceHistory ph ON p.Id = ph.ProductId
            //    JOIN Discount d ON p.Id = d.ProductId
            //    JOIN Brand b ON p.BrandId = b.Id;
            //");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS vw_CategoryProducts");
        }
    }
}
