using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "Description", "Img", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]", "/img/product01.png", "Laptop ASUS Air G3425", 5m },
                    { 2, 6, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, Windows 10]", "/img/product01.png", "Laptop Lenovo C1124", 0m },
                    { 3, 3, "[i5, 1.8/8Gb/128SSD, (MQD32RU/A)]", "/img/product03.png", "Laptop Mackbook Air 2", 3m },
                    { 4, 8, "[1920x1200, IPS, 8х2.36 GGz, 3 GB, BT, GPS, 5100 mAh, Android 8.x+]", "/img/product04.png", "Tablet Sony Z3", 4m },
                    { 5, 7, "[5.1, Closed-Back, 20 Gz - 25000 Gz, 35Ω, wired, cable - 2 m, black]", "/img/product05.png", "Headphones Epson GT23", 5m },
                    { 6, 2, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]", "/img/product06.png", "Laptop Acer H2451", 4m },
                    { 7, 1, "[Intel Celeron J4005, 2x2000 MGz, 6 GB DDR3, SSD 120 GB, without OS]", "/img/product07.png", "Laptop ASUS Air G3425", 1m },
                    { 8, 1, "[Intel Celeron J4005, 2x4000 MGz, 8 GB DDR3, SSD 120 GB, Windows 10]", "/img/product08.png", "Laptop ASUS Air G5161", 2m },
                    { 9, 1, "[Intel Celeron J4005, 2x2000 MGz, 16 GB DDR3, SSD 1 TB, Windows 10]", "/img/product09.png", "Laptop ASUS Air G9515", 3m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
