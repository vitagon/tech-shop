using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateProductPAVPairTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPAVPair",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    PAVPairId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPAVPair", x => new { x.ProductId, x.PAVPairId });
                    table.ForeignKey(
                        name: "FK_ProductPAVPair_PAVPair_PAVPairId",
                        column: x => x.PAVPairId,
                        principalTable: "PAVPair",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPAVPair_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPAVPair_PAVPairId",
                table: "ProductPAVPair",
                column: "PAVPairId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPAVPair");
        }
    }
}
