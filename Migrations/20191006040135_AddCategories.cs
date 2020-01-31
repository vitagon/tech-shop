using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace TechShop.Migrations
{
    public partial class AddCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into Category (Lft, Rgt, [Name], ParentId, Level, Url) values
                    (1,  38, 'Categories',              0,  0, ''),
                    (2,  7,  'Computers and laptops',   1,  1, 'computers-and-laptops'),
                    (3,  6,  'Laptops',                 2,  2, 'laptops'),
                    (4,  5,  'All Laptops',             3,  3, 'all-laptops'),
                    (8,  17, 'Photo and video',         1,  1, 'photo-and-video'),
                    (9,  10, 'Cameras',                 5,  2, 'cameras'),
                    (11, 16, 'Lenses, optics, flashes', 5,  2, 'lenses-optics-flashes'),
                    (12, 15, 'Lenses',                  7,  3, 'lenses'),
                    (18, 27, 'TVs, audio, video',       1,  1, 'tvs-audio-video'),
                    (19, 26, 'TVs',                     9,  2, 'tvs'),
                    (20, 21, 'All TVs',                 10, 3, 'all-tvs'),
                    (22, 23, 'Smart-TVs',               10, 3, 'smart-tvs'),
                    (24, 25, 'OLED TVs',                10, 3, 'oled-tvs'),
                    (28, 37, 'Smartphones and gadgets', 1,  1, 'smartphones-and-gadgets'),
                    (29, 32, 'Smartphones',             14, 2, 'smartphones'),
                    (30, 31, 'All Smartphones',         15, 3, 'all-smartphones'),
                    (33, 36, 'Tablets',                 14, 2, 'tablets'),
                    (34, 35, 'All Tablets',             17, 3, 'all-tablets')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Category where Id between 1 and 18;
            ");
        }
    }
}
