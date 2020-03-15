using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPAVPairsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PAVPair",
                columns: new[] { "Id", "AttributeId", "PAttributeId", "PValueId", "ValueId" },
                values: new object[,]
                {
                    { 1, 1, null, null, 1 },
                    { 55, 6, null, null, 55 },
                    { 54, 6, null, null, 54 },
                    { 53, 6, null, null, 53 },
                    { 52, 6, null, null, 52 },
                    { 51, 6, null, null, 51 },
                    { 50, 6, null, null, 50 },
                    { 49, 6, null, null, 49 },
                    { 48, 6, null, null, 48 },
                    { 47, 6, null, null, 47 },
                    { 46, 6, null, null, 46 },
                    { 45, 6, null, null, 45 },
                    { 44, 6, null, null, 44 },
                    { 43, 6, null, null, 43 },
                    { 42, 6, null, null, 42 },
                    { 41, 5, null, null, 41 },
                    { 56, 6, null, null, 56 },
                    { 57, 7, null, null, 57 },
                    { 58, 7, null, null, 58 },
                    { 59, 7, null, null, 59 },
                    { 75, 11, null, null, 75 },
                    { 74, 10, null, null, 74 },
                    { 73, 10, null, null, 73 },
                    { 72, 10, null, null, 72 },
                    { 71, 10, null, null, 71 },
                    { 70, 10, null, null, 70 },
                    { 69, 10, null, null, 69 },
                    { 40, 5, null, null, 40 },
                    { 68, 10, null, null, 68 },
                    { 66, 9, null, null, 66 },
                    { 65, 8, null, null, 65 },
                    { 64, 8, null, null, 64 },
                    { 63, 8, null, null, 63 },
                    { 62, 8, null, null, 62 },
                    { 61, 8, null, null, 61 },
                    { 60, 7, null, null, 60 },
                    { 67, 9, null, null, 67 },
                    { 76, 11, null, null, 76 },
                    { 39, 5, null, null, 39 },
                    { 37, 5, null, null, 37 },
                    { 16, 3, null, null, 16 },
                    { 15, 2, null, null, 15 },
                    { 14, 2, null, null, 14 },
                    { 13, 2, null, null, 13 },
                    { 12, 2, null, null, 12 },
                    { 11, 2, null, null, 11 },
                    { 10, 2, null, null, 10 },
                    { 9, 1, null, null, 9 },
                    { 8, 1, null, null, 8 },
                    { 7, 1, null, null, 7 },
                    { 6, 1, null, null, 6 },
                    { 5, 1, null, null, 5 },
                    { 4, 1, null, null, 4 },
                    { 3, 1, null, null, 3 },
                    { 2, 1, null, null, 2 },
                    { 17, 3, null, null, 17 },
                    { 18, 3, null, null, 18 },
                    { 19, 3, null, null, 19 },
                    { 20, 3, null, null, 20 },
                    { 36, 5, null, null, 36 },
                    { 35, 5, null, null, 35 },
                    { 34, 5, null, null, 34 },
                    { 33, 5, null, null, 33 },
                    { 32, 5, null, null, 32 },
                    { 31, 5, null, null, 31 },
                    { 30, 5, null, null, 30 },
                    { 38, 5, null, null, 38 },
                    { 29, 5, null, null, 29 },
                    { 27, 4, null, null, 27 },
                    { 26, 4, null, null, 26 },
                    { 25, 4, null, null, 25 },
                    { 24, 4, null, null, 24 },
                    { 23, 4, null, null, 23 },
                    { 22, 4, null, null, 22 },
                    { 21, 4, null, null, 21 },
                    { 28, 4, null, null, 28 },
                    { 77, 11, null, null, 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PAVPair",
                keyColumn: "Id",
                keyValue: 65);

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
        }
    }
}
