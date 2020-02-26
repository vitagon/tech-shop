using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateCategoryProductsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_CategoryProducts
                AS
                SELECT
	                p.Id, p.[Name], p.[Description], p.Img, p.Price, p.OldPrice, p.Sale, p.Rating,
	                c.Id as CatId, c.Lft, c.Rgt, c.[Name] as CatName, c.ParentId, c.[Level], c.[Url] as CatUrl
                FROM
	                Product p
                JOIN CategoryProduct cp on p.Id = cp.ProductId
                JOIN Category c on cp.CategoryId = c.Id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS vw_CategoryProducts");
        }
    }
}
