using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddCategoriesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Level", "Lft", "Name", "ParentId", "Rgt", "Url" },
                values: new object[,]
                {
                    { 1, 0, 1, "Categories", 0, 38, "" },
                    { 16, 3, 30, "All Smartphones", 15, 31, "all-smartphones" },
                    { 15, 2, 29, "Smartphones", 14, 32, "smartphones" },
                    { 14, 1, 28, "Smartphones and gadgets", 1, 37, "smartphones-and-gadgets" },
                    { 13, 3, 24, "OLED TVs", 10, 25, "oled-tvs" },
                    { 12, 3, 22, "Smart-TVs", 10, 23, "smart-tvs" },
                    { 11, 3, 20, "All TVs", 10, 21, "all-tvs" },
                    { 10, 2, 19, "TVs", 9, 26, "tvs" },
                    { 9, 1, 18, "TVs, audio, video", 1, 27, "tvs-audio-video" },
                    { 8, 3, 12, "Lenses", 7, 15, "lenses" },
                    { 7, 2, 11, "Lenses, optics, flashes", 5, 16, "lenses-optics-flashes" },
                    { 6, 2, 9, "Cameras", 5, 10, "cameras" },
                    { 5, 1, 8, "Photo and video", 1, 17, "photo-and-video" },
                    { 4, 3, 4, "All Laptops", 3, 5, "all-laptops" },
                    { 3, 2, 3, "Laptops", 2, 6, "laptops" },
                    { 2, 1, 2, "Computers and laptops", 1, 7, "computers-and-laptops" },
                    { 17, 2, 33, "Tablets", 14, 36, "tablets" },
                    { 18, 3, 34, "All Tablets", 17, 35, "all-tablets" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
