using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreatePFilterPAVPairTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PFilterPAVPair",
                columns: table => new
                {
                    PFilterId = table.Column<int>(nullable: false),
                    PAVPairId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFilterPAVPair", x => new { x.PFilterId, x.PAVPairId });
                    table.ForeignKey(
                        name: "FK_PFilterPAVPair_PAVPair_PAVPairId",
                        column: x => x.PAVPairId,
                        principalTable: "PAVPair",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PFilterPAVPair_PFilter_PFilterId",
                        column: x => x.PFilterId,
                        principalTable: "PFilter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PFilterPAVPair_PAVPairId",
                table: "PFilterPAVPair",
                column: "PAVPairId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFilterPAVPair");
        }
    }
}
