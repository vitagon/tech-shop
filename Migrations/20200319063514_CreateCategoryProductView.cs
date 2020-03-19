using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateCategoryProductView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_CategoryProduct
                AS
                SELECT
                    c.Id AS CatId, c.[Name] AS CatName, c.ParentId AS CatParentId, c.[Level] AS CatLevel, c.[Url] AS CatUrl,
                    p.Id AS ProductId, p.[Name] AS ProductName, p.[Description] AS ProductDescription, p.Img AS ProductImg, p.BrandId AS ProductBrandId, p.Rating AS ProductRating
                FROM Category c 
                JOIN CategoryProduct cp ON c.Id = cp.CategoryId
                JOIN Product p ON cp.ProductId = p.Id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_PFilterPAVPair");
        }
    }
}
