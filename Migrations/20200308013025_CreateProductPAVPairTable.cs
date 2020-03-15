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
                    AVPairId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ProductPAVPair_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.ForeignKey(
                        name: "FK_ProductPAVPair_PAVPair_PAVPairId",
                        column: x => x.AVPairId,
                        principalTable: "PAVPair",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.PrimaryKey(
                        name: "PK_ProductPAVPair",
                        columns: x => new { x.ProductId, x.AVPairId });
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPAVPair_AVPairId",
                table: "ProductPAVPair",
                column: "AVPairId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPAVPair");
        }
    }
}
