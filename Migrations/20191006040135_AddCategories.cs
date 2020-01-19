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
                insert into Category (Lft, Rgt, [Name], ParentId, Level) values
                    (1,  38, 'root',                                     0,  0),
                    (2,  7,  'Computers',                                1,  1),
                    (3,  6,  'Computers, laptops and software',          2,  2),
                    (4,  5,  'Laptops',                                  3,  3),
                    (8,  17, 'Accessories',                              1,  1),
                    (9,  10, 'For mobiles',                              5,  2),
                    (11, 16, 'For computers and laptops',                5,  2),
                    (12, 15, 'Audio',                                    7,  3),
                    (13, 14, 'Headphones and headsets',                  8,  4),
                    (18, 27, 'TV and entertainment',                     1,  1),
                    (19, 26, 'TV and accessories',                       10, 2),
                    (20, 21, 'TVs',                                      11, 3),
                    (22, 23, 'TV wall brackets',                         11, 3),
                    (24, 25, 'TV stands and cabinets',                   11, 3),
                    (28, 37, 'Smartphones, tablets and photo equipment', 11, 1),
                    (29, 32, 'Smartphones and gadgets',                  11, 2),
                    (30, 31, 'Smartphones',                              11, 3),
                    (33, 36, 'Tablets, e-books',                         11, 2),
                    (34, 35, 'Tablets',                                  11, 3)
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from Category where Id between 1 and 19;
            ");
        }
    }
}
