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
                insert into Category (Id, Lft, Rgt, [Name], ParentId, Level) values
                    (1,  1,  28, 'root',                            0,  0),
                    (2,  2,  7,  'Computers',                       1,  1),
                    (3,  3,  6,  'Computers, laptops and software', 2,  2)
                    (4,  4,  5,  'Laptops',                         3,  3),
                    (5,  8,  17, 'Accessories',                     1,  1),
                    (6,  9,  10, 'For mobiles',                     5,  2),
                    (7,  11, 16, 'For computers and laptops',       5,  2),
                    (8,  12, 15, 'Audio',                           7,  3),
                    (9,  13, 14, 'Headphones and headsets',         8,  4),
                    (10, 18, 27, 'TV and entertainment',            1,  1),
                    (11, 19, 26, 'TV and accessories',              10, 2),
                    (12, 20, 21, 'TVs',                             11, 3),
                    (13, 22, 23, 'TV wall brackets',                11, 3),
                    (14, 24, 25, 'TV stands and cabinets',          11, 3),
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Category where Id between 1 and 14;
            ");
        }
    }
}
