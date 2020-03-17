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
                    FilterId = table.Column<int>(nullable: false),
                    AVPairId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFilterPAVPair", x => new { x.FilterId, x.AVPairId });

                    table.ForeignKey(
                        name: "FK_PFilterPAVPair_PFilter_FilterId",
                        column: x => x.FilterId,
                        principalTable: "PFilter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.ForeignKey(
                        name: "FK_PFilterPAVPair_PAVPair_AVPairId",
                        column: x => x.AVPairId,
                        principalTable: "PAVPair",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "PFilterPAVPair");
        }
    }
}
