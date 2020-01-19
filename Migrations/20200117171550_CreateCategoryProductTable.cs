using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateCategoryProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.ForeignKey(
                        name: "FK_CategoryProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.PrimaryKey(
                        name: "PK_CategoryProduct",
                        columns: x => new { x.CategoryId, x.ProductId});
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("CategoryProduct");
        }
    }
}
