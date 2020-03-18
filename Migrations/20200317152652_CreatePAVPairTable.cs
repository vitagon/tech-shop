using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreatePAVPairTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PAVPair",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAttributeId = table.Column<int>(nullable: false),
                    PValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAVPair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PAVPair_PAttribute_PAttributeId",
                        column: x => x.PAttributeId,
                        principalTable: "PAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PAVPair_PValue_PValueId",
                        column: x => x.PValueId,
                        principalTable: "PValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PAVPair_PValueId",
                table: "PAVPair",
                column: "PValueId");

            migrationBuilder.CreateIndex(
                name: "IX_PAVPair_PAttributeId_PValueId",
                table: "PAVPair",
                columns: new[] { "PAttributeId", "PValueId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAVPair");
        }
    }
}
