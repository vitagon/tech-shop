using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreatePFilterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PFilter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFilterNameId = table.Column<int>(nullable: false),
                    PFilterValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFilter", x => x.Id);

                    table.ForeignKey(
                        name: "FK_PFilter_PFilterName_PFilterNameId",
                        column: x => x.PFilterNameId,
                        principalTable: "PFilterName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.ForeignKey(
                        name: "FK_PFilter_PFilterValue_PFilterValueId",
                        column: x => x.PFilterValueId,
                        principalTable: "PFilterValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PFilter_PFilterNameId",
                table: "PFilter",
                column: "PFilterNameId");

            migrationBuilder.CreateIndex(
                name: "IX_PFilter_PFilterValueId",
                table: "PFilter",
                column: "PFilterValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "PFilter");
        }
    }
}
