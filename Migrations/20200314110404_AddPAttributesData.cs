using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPAttributesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PAttribute",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "RAM" },
                    { 2, "Hard Drive" },
                    { 3, "Display Size" },
                    { 4, "Display Resolution" },
                    { 5, "Processor Type" },
                    { 6, "Number of CPU Cores" },
                    { 7, "Operating System" },
                    { 8, "Graphics Type" },
                    { 9, "Graphics Processor" },
                    { 10, "Graphics Brand" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
