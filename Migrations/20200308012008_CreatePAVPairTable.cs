using Microsoft.EntityFrameworkCore.Metadata;
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(nullable: false),
                    ValueId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAVPair", x => x.Id);

                    table.ForeignKey(
                        name: "FK_PAVPair_PAttribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "PAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);

                    table.ForeignKey(
                        name: "FK_PAVPair_PValue_ValueId",
                        column: x => x.ValueId,
                        principalTable: "PValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PAVPair_AttributeId",
                table: "PAVPair",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_PAVPair_ValueId",
                table: "PAVPair",
                column: "ValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAVPair");
        }
    }
}
