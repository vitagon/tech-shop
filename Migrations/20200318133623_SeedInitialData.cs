using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Asus" },
                    { 8, "Sony" },
                    { 7, "Epson" },
                    { 6, "Lenovo" },
                    { 9, "Samsung" },
                    { 4, "Dell" },
                    { 3, "Apple" },
                    { 2, "Acer" },
                    { 5, "HP" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Level", "Name", "ParentId", "Url" },
                values: new object[] { 1, 0, "Categories", 0, "" });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "Description", "EndDate", "Rate", "StartDate" },
                values: new object[,]
                {
                    { 1, "New Year Sale", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15m, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "First Year of Shop Opening", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Special Laptops Sale", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5m, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PAttribute",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Operating System" },
                    { 11, "Graphics Brand" },
                    { 10, "Graphics Processor" },
                    { 9, "Graphics Type" },
                    { 7, "Number of CPU Cores" },
                    { 3, "SSD Size" },
                    { 5, "Display Resolution" },
                    { 4, "Display Size" },
                    { 2, "HDD Size" },
                    { 1, "RAM" },
                    { 6, "Processor Type" }
                });

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
                    { 8, "257 to 512 GB" },
                    { 12, "Unix" },
                    { 10, "Windows" },
                    { 9, "513 to 1024 GB" },
                    { 7, "128 to 256 GB" },
                    { 11, "MacOS" },
                    { 5, "12 GB" },
                    { 4, "8 GB" },
                    { 3, "6 GB" },
                    { 2, "4 GB" },
                    { 1, "2 GB" },
                    { 6, "16 GB" }
                });

            migrationBuilder.InsertData(
                table: "PValue",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 56, "AMD A9" },
                    { 55, "AMD Razen 3" },
                    { 54, "AMD Razen 5" },
                    { 53, "AMD Razen 7" },
                    { 52, "Intel Atom" },
                    { 51, "Intel Celeron" },
                    { 50, "Intel Pentium" },
                    { 47, "Intel Core M7" },
                    { 48, "Intel Core M5" },
                    { 46, "Intel Xeon" },
                    { 45, "Intel Core i3" },
                    { 44, "Intel Core i5" },
                    { 43, "Intel Core i7" },
                    { 42, "Intel Core i9" },
                    { 41, "3840x2160" },
                    { 49, "Intel Core M3" },
                    { 57, "2" },
                    { 60, "8" },
                    { 59, "6" },
                    { 40, "3200x1800" },
                    { 75, "AMD" },
                    { 74, "GeForce MX230" },
                    { 73, "GeForce MX250" },
                    { 72, "Radeon 540X" },
                    { 71, "GeForce RTX 2070 MaxQ" },
                    { 70, "GeForce RTX 2070" },
                    { 58, "4" },
                    { 69, "GeForce RTX 2080 MaxQ" },
                    { 67, "Dedicated & Integrated" },
                    { 66, "Integrated" },
                    { 65, "MacOS" },
                    { 64, "Chrome OS" },
                    { 63, "UNIX" },
                    { 62, "Windows 10 Professional" },
                    { 61, "Windows 10 Home" },
                    { 68, "GeForce RTX 2080" },
                    { 39, "3072x1920" },
                    { 19, "512 GB" },
                    { 37, "2880x1800" },
                    { 16, "128 GB" },
                    { 15, "2500 GB" },
                    { 14, "2000 GB" },
                    { 13, "1500 GB" },
                    { 12, "1000 GB" },
                    { 11, "500 GB" },
                    { 10, "None" },
                    { 17, "180 GB" },
                    { 9, "64 GB" },
                    { 7, "24 GB" },
                    { 6, "16 GB" },
                    { 5, "12 GB" },
                    { 4, "8 GB" },
                    { 3, "6 GB" },
                    { 2, "4 GB" },
                    { 1, "2 GB" },
                    { 8, "32 GB" },
                    { 38, "3000x2000" },
                    { 18, "256 GB" },
                    { 20, "1024 GB" },
                    { 36, "2560x1600" },
                    { 35, "2304x1440" },
                    { 34, "2160x1440" },
                    { 33, "1920x1080" },
                    { 32, "1600x900" },
                    { 31, "1440x900" },
                    { 30, "1366x912" },
                    { 76, "Intel" },
                    { 29, "1366x768" },
                    { 27, "15.6\"" },
                    { 26, "14\"" },
                    { 25, "13.3\"" },
                    { 24, "12.5\"" },
                    { 23, "12\"" },
                    { 22, "11.6\"" },
                    { 21, "11\"" },
                    { 28, "17.3\"" },
                    { 77, "nVidia" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Level", "Name", "ParentId", "Url" },
                values: new object[,]
                {
                    { 2, 1, "Computers and laptops", 1, "computers-and-laptops" },
                    { 5, 1, "Photo and video", 1, "photo-and-video" },
                    { 9, 1, "TVs, audio, video", 1, "tvs-audio-video" },
                    { 14, 1, "Smartphones and gadgets", 1, "smartphones-and-gadgets" }
                });

            migrationBuilder.InsertData(
                table: "PAVPair",
                columns: new[] { "Id", "PAttributeId", "PValueId" },
                values: new object[,]
                {
                    { 26, 4, 26 },
                    { 50, 6, 50 },
                    { 49, 6, 49 },
                    { 48, 6, 48 },
                    { 47, 6, 47 },
                    { 46, 6, 46 },
                    { 45, 6, 45 },
                    { 44, 6, 44 },
                    { 43, 6, 43 },
                    { 42, 6, 42 },
                    { 41, 5, 41 },
                    { 39, 5, 39 },
                    { 51, 6, 51 },
                    { 38, 5, 38 },
                    { 37, 5, 37 },
                    { 36, 5, 36 },
                    { 35, 5, 35 },
                    { 34, 5, 34 },
                    { 33, 5, 33 },
                    { 32, 5, 32 },
                    { 31, 5, 31 },
                    { 40, 5, 40 },
                    { 52, 6, 52 },
                    { 55, 6, 55 },
                    { 54, 6, 54 },
                    { 75, 11, 75 },
                    { 74, 10, 74 },
                    { 73, 10, 73 },
                    { 72, 10, 72 },
                    { 71, 10, 71 },
                    { 70, 10, 70 },
                    { 69, 10, 69 },
                    { 68, 10, 68 },
                    { 67, 9, 67 },
                    { 66, 9, 66 },
                    { 65, 8, 65 },
                    { 64, 8, 64 },
                    { 63, 8, 63 },
                    { 62, 8, 62 },
                    { 61, 8, 61 },
                    { 60, 7, 60 },
                    { 59, 7, 59 },
                    { 58, 7, 58 },
                    { 57, 7, 57 },
                    { 56, 6, 56 },
                    { 30, 5, 30 },
                    { 53, 6, 53 },
                    { 29, 5, 29 },
                    { 77, 11, 77 },
                    { 27, 4, 27 },
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 28, 4, 28 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 1, 9 },
                    { 10, 2, 10 },
                    { 11, 2, 11 },
                    { 12, 2, 12 },
                    { 13, 2, 13 },
                    { 3, 1, 3 },
                    { 15, 2, 15 },
                    { 76, 11, 76 },
                    { 25, 4, 25 },
                    { 24, 4, 24 },
                    { 14, 2, 14 },
                    { 22, 4, 22 },
                    { 23, 4, 23 },
                    { 20, 3, 20 },
                    { 19, 3, 19 },
                    { 18, 3, 18 },
                    { 17, 3, 17 },
                    { 16, 3, 16 },
                    { 21, 4, 21 }
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
                    { 8, 2, 8 },
                    { 7, 2, 7 },
                    { 9, 2, 9 },
                    { 10, 3, 10 },
                    { 11, 3, 11 },
                    { 12, 3, 12 },
                    { 6, 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "Description", "Img", "Name", "Rating" },
                values: new object[,]
                {
                    { 4, 8, "[1920x1200, IPS, 8х2.36 GGz, 3 GB, BT, GPS, 5100 mAh, Android 8.x+]", "/img/product04.png", "Tablet Sony Z3", 4m },
                    { 5, 7, "[5.1, Closed-Back, 20 Gz - 25000 Gz, 35Ω, wired, cable - 2 m, black]", "/img/product05.png", "Headphones Epson GT23", 5m },
                    { 2, 6, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]", "/img/product01.png", "Laptop Lenovo C1124", 0m },
                    { 3, 3, "[i5, 1.8/8Gb/128SSD, (MQD32RU/A)]", "/img/product03.png", "Laptop Mackbook Air 2", 3m },
                    { 6, 2, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Professional]", "/img/product06.png", "Laptop Acer H2451", 4m },
                    { 9, 1, "[Intel Celeron J4005, 2x2000 MGz, 16 GB DDR3, SSD 512 GB, Windows 10 Professional]", "/img/product09.png", "Laptop ASUS Air G9515", 3m },
                    { 8, 1, "[Intel Celeron J4005, 2x4000 MGz, 8 GB DDR3, SSD 128 GB, Windows 10 Professional]", "/img/product08.png", "Laptop ASUS Air G5161", 2m },
                    { 7, 1, "[Intel Celeron J4005, 2x2000 MGz, 6 GB DDR3, SSD 128 GB, Windows 10 Professional]", "/img/product07.png", "Laptop ASUS Air G3425", 1m },
                    { 1, 1, "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]", "/img/product01.png", "Laptop ASUS Air G3425", 5m }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Level", "Name", "ParentId", "Url" },
                values: new object[,]
                {
                    { 15, 2, "Smartphones", 14, "smartphones" },
                    { 10, 2, "TVs", 9, "tvs" },
                    { 7, 2, "Lenses, optics, flashes", 5, "lenses-optics-flashes" },
                    { 3, 2, "Laptops", 2, "laptops" },
                    { 6, 2, "Cameras", 5, "cameras" },
                    { 17, 2, "Tablets", 14, "tablets" }
                });

            migrationBuilder.InsertData(
                table: "PFilterPAVPair",
                columns: new[] { "PFilterId", "PAVPairId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 1, 1 },
                    { 2, 2 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 16 },
                    { 7, 17 },
                    { 8, 19 },
                    { 9, 20 },
                    { 11, 65 },
                    { 10, 61 },
                    { 10, 62 },
                    { 12, 63 },
                    { 7, 18 }
                });

            migrationBuilder.InsertData(
                table: "PriceHistory",
                columns: new[] { "Id", "Description", "Price", "ProductId", "StartDate" },
                values: new object[,]
                {
                    { 11, "Purchase price increased", 165m, 2, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Initial", 150m, 2, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Initial", 150m, 5, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Purchase price increased", 156m, 5, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Purchase price increased", 193m, 3, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Initial", 150m, 1, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Purchase price increased", 176m, 6, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Initial", 150m, 6, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Purchase price increased", 169m, 4, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Purchase price increased", 165m, 9, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Initial", 150m, 9, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Purchase price increased", 173m, 8, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Initial", 150m, 8, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Purchase price increased", 181m, 7, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Initial", 150m, 7, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Purchase price increased", 167m, 1, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Initial", 150m, 3, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Initial", 150m, 4, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductDiscount",
                columns: new[] { "ProductId", "DiscountId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 5, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 8, 2 },
                    { 6, 3 },
                    { 2, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 2, 2 },
                    { 2, 1 },
                    { 3, 3 },
                    { 3, 2 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductPAVPair",
                columns: new[] { "ProductId", "PAVPairId" },
                values: new object[,]
                {
                    { 9, 62 },
                    { 8, 62 },
                    { 7, 62 },
                    { 6, 62 },
                    { 2, 61 },
                    { 1, 61 },
                    { 9, 19 },
                    { 7, 3 },
                    { 8, 16 },
                    { 7, 16 },
                    { 6, 16 },
                    { 3, 16 },
                    { 2, 16 },
                    { 1, 16 },
                    { 9, 6 },
                    { 1, 2 },
                    { 8, 4 },
                    { 3, 4 },
                    { 2, 2 },
                    { 6, 2 },
                    { 3, 65 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Level", "Name", "ParentId", "Url" },
                values: new object[,]
                {
                    { 4, 3, "All Laptops", 3, "all-laptops" },
                    { 8, 3, "Lenses", 7, "lenses" },
                    { 11, 3, "All TVs", 10, "all-tvs" },
                    { 12, 3, "Smart-TVs", 10, "smart-tvs" },
                    { 13, 3, "OLED TVs", 10, "oled-tvs" },
                    { 16, 3, "All Smartphones", 15, "all-smartphones" },
                    { 18, 3, "All Tablets", 17, "all-tablets" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 2 },
                    { 4, 5 },
                    { 18, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

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
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 10, 61 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 10, 62 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 11, 65 });

            migrationBuilder.DeleteData(
                table: "PFilterPAVPair",
                keyColumns: new[] { "PFilterId", "PAVPairId" },
                keyValues: new object[] { 12, 63 });

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PriceHistory",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductDiscount",
                keyColumns: new[] { "ProductId", "DiscountId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 6, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 7, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 8, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "PAVPairId" },
                keyValues: new object[] { 9, 62 });

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 2);

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
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PFilter",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 77);

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

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PFilterName",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PFilterName",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PFilterName",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PFilterValue",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
