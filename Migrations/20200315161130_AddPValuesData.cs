using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddPValuesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "HDD Size");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "SSD Size");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Display Size");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Display Resolution");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Processor Type");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Number of CPU Cores");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Operating System");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Graphics Type");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Graphics Processor");

            migrationBuilder.InsertData(
                table: "PAttribute",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Graphics Brand" });

            migrationBuilder.InsertData(
                table: "PValue",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 10, "None" },
                    { 64, "Chrome OS" },
                    { 63, "UNIX" },
                    { 62, "Windows 10 Professional" },
                    { 61, "Windows 10 Home" },
                    { 60, "8" },
                    { 59, "6" },
                    { 58, "4" },
                    { 57, "2" },
                    { 56, "AMD A9" },
                    { 55, "AMD Razen 3" },
                    { 54, "AMD Razen 5" },
                    { 53, "AMD Razen 7" },
                    { 52, "Intel Atom" },
                    { 51, "Intel Celeron" },
                    { 50, "Intel Pentium" },
                    { 65, "MacOS" },
                    { 66, "Integrated" },
                    { 67, "Dedicated & Integrated" },
                    { 68, "GeForce RTX 2080" },
                    { 1, "2 GB" },
                    { 2, "4 GB" },
                    { 3, "6 GB" },
                    { 4, "8 GB" },
                    { 5, "12 GB" },
                    { 6, "16 GB" },
                    { 7, "24 GB" },
                    { 49, "Intel Core M3" },
                    { 77, "nVidia" },
                    { 75, "AMD" },
                    { 74, "GeForce MX230" },
                    { 73, "GeForce MX250" },
                    { 72, "Radeon 540X" },
                    { 71, "GeForce RTX 2070 MaxQ" },
                    { 70, "GeForce RTX 2070" },
                    { 69, "GeForce RTX 2080 MaxQ" },
                    { 76, "Intel" },
                    { 9, "64 GB" },
                    { 48, "Intel Core M5" },
                    { 46, "Intel Xeon" },
                    { 25, "13.3\"" },
                    { 24, "12.5\"" },
                    { 23, "12\"" },
                    { 22, "11.6\"" },
                    { 21, "11\"" },
                    { 20, "1024 GB" },
                    { 19, "512 GB" },
                    { 18, "256 GB" },
                    { 17, "180 GB" },
                    { 16, "128 GB" },
                    { 15, "2500 GB" },
                    { 14, "2000 GB" },
                    { 13, "1500 GB" },
                    { 12, "1000 GB" },
                    { 11, "500 GB" },
                    { 26, "14\"" },
                    { 27, "15.6\"" },
                    { 28, "17.3\"" },
                    { 29, "1366x768" },
                    { 45, "Intel Core i3" },
                    { 44, "Intel Core i5" },
                    { 8, "32 GB" },
                    { 42, "Intel Core i9" },
                    { 41, "3840x2160" },
                    { 40, "3200x1800" },
                    { 39, "3072x1920" },
                    { 47, "Intel Core M7" },
                    { 38, "3000x2000" },
                    { 36, "2560x1600" },
                    { 35, "2304x1440" },
                    { 34, "2160x1440" },
                    { 33, "1920x1080" },
                    { 32, "1600x900" },
                    { 31, "1440x900" },
                    { 30, "1366x912" },
                    { 37, "2880x1800" },
                    { 43, "Intel Core i7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 11);

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
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PValue",
                keyColumn: "Id",
                keyValue: 65);

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

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Hard Drive");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Display Size");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Display Resolution");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Processor Type");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Number of CPU Cores");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Operating System");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Graphics Type");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Graphics Processor");

            migrationBuilder.UpdateData(
                table: "PAttribute",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Graphics Brand");
        }
    }
}
