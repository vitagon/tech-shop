using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPFilterPAVPairData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PFilterPAVPair",
                columns: new[] { "FilterId", "AVPairId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 8, 19 },
                    { 9, 20 },
                    { 10, 61 },
                    { 10, 62 },
                    { 11, 65 },
                    { 12, 63 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFilterPAVPair");
        }
    }
}
