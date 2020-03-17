using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPriceHistoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PriceHistory",
                columns: new[] { "Id", "Description", "Price", "ProductId", "StartDate" },
                values: new object[,]
                {
                    { 1, "Initial", 150m, 1, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Purchase price increased", 181m, 7, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Purchase price increased", 176m, 6, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Purchase price increased", 156m, 5, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Purchase price increased", 169m, 4, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Purchase price increased", 193m, 3, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Purchase price increased", 165m, 2, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Purchase price increased", 167m, 1, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Initial", 150m, 9, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Initial", 150m, 8, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Initial", 150m, 7, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Initial", 150m, 6, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Initial", 150m, 5, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Initial", 150m, 4, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Initial", 150m, 3, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Initial", 150m, 2, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Purchase price increased", 173m, 8, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Purchase price increased", 165m, 9, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
