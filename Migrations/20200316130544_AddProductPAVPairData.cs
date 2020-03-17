using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddProductPAVPairData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Home]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 128 GB, Windows 10 Professional]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 6 GB DDR3, SSD 128 GB, Windows 10 Professional]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "[Intel Celeron J4005, 2x4000 MGz, 8 GB DDR3, SSD 128 GB, Windows 10 Professional]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 16 GB DDR3, SSD 512 GB, Windows 10 Professional]");

            migrationBuilder.InsertData(
                table: "ProductPAVPair",
                columns: new[] { "ProductId", "AVPairId" },
                values: new object[,]
                {
                    { 9, 62 },
                    { 8, 62 },
                    { 7, 62 },
                    { 6, 62 },
                    { 3, 65 },
                    { 2, 61 },
                    { 1, 61 },
                    { 9, 19 },
                    { 7, 16 },
                    { 6, 16 },
                    { 3, 16 },
                    { 2, 16 },
                    { 1, 16 },
                    { 9, 6 },
                    { 8, 4 },
                    { 7, 3 },
                    { 6, 2 },
                    { 3, 4 },
                    { 2, 2 },
                    { 8, 16 },
                    { 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 2, 61 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 3, 65 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 6, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 7, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 8, 62 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "ProductPAVPair",
                keyColumns: new[] { "ProductId", "AVPairId" },
                keyValues: new object[] { 9, 62 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, Windows 10]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 6 GB DDR3, SSD 120 GB, without OS]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "[Intel Celeron J4005, 2x4000 MGz, 8 GB DDR3, SSD 120 GB, Windows 10]");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "[Intel Celeron J4005, 2x2000 MGz, 16 GB DDR3, SSD 1 TB, Windows 10]");
        }
    }
}
