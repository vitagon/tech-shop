using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into Category (Name, ParentId) values " +
                "   ('cellphones', 0)," +
                "   ('laptops', 0)"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "delete from Category where Name in ('cellphones','laptops')"
            );
        }
    }
}
