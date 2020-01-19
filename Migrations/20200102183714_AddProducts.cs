using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace TechShop.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into Product ([Name], [Description], Img, Price, OldPrice, Sale, Rating) values
                    ('Laptop ASUS Air G3425',   '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]', '/img/product01.png', 150, 183, 30, 5),
                    ('Headphones Lenovo C1124', '[7.1, Closed-Back, 20 Gz - 20000 Gz, 35Ω, wired, cable - 2 m, black]', '/img/product02.png', 60,  72,  0,  0),
                    ('Laptop Mackbook Air 2',   '[i5, 1.8/8Gb/128SSD, (MQD32RU/A)]',                                    '/img/product03.png', 580, 590, 0,  3),
                    ('Tablet Sony Z3',          '[1920x1200, IPS, 8х2.36 GGz, 3 GB, BT, GPS, 5100 mAh, Android 8.x+]',  '/img/product04.png', 74,  0,   0,  4),
                    ('Headphones Epson GT23',   '[5.1, Closed-Back, 20 Gz - 25000 Gz, 35Ω, wired, cable - 2 m, black]', '/img/product05.png', 65,  0,   0,  5),
                    ('Laptop Acer H2451',       '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]', '/img/product06.png', 150, 183, 30, 5),
                    ('Laptop ASUS Air G3425',   '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]', '/img/product07.png', 150, 183, 30, 5),
                    ('Laptop ASUS Air G5161',   '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]', '/img/product08.png', 150, 183, 30, 5),
                    ('Laptop ASUS Air G9515',   '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]', '/img/product09.png', 150, 183, 30, 5)
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Product where Id between 1 and 9;
            ");
        }
    }
}
