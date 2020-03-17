using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPFiltersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PFilterName",
                columns: new[] { "Id", "FilterName" },
                values: new object[,]
                {
                    { 1, "RAM Size" },
                    { 2, "SSD size" },
                    { 3, "Operating System" }
                });

            migrationBuilder.InsertData(
                table: "PFilterValue",
                columns: new[] { "Id", "FilterValue" },
                values: new object[,]
                {
                    { 1, "2 GB" },
                    { 2, "4 GB" },
                    { 3, "6 GB" },
                    { 4, "8 GB" },
                    { 5, "12 GB" },
                    { 6, "16 GB" },
                    { 7, "128 to 256 GB" },
                    { 8, "257 to 512 GB" },
                    { 9, "513 to 1024 GB" },
                    { 10, "Windows" },
                    { 11, "MacOS" },
                    { 12, "Unix" }
                });

            migrationBuilder.InsertData(
                table: "PFilter",
                columns: new[] { "Id", "PFilterNameId", "PFilterValueId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 7 },
                    { 8, 2, 8 },
                    { 9, 2, 9 },
                    { 10, 3, 10 },
                    { 11, 3, 11 },
                    { 12, 3, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFilter");

            migrationBuilder.DropTable(
                name: "PFilterName");

            migrationBuilder.DropTable(
                name: "PFilterValue");
        }
    }
}
