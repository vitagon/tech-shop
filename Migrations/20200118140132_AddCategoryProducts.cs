using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddCategoryProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into CategoryProduct (CategoryId, ProductId) values
                    (4, 1), (4, 3), (4, 6), (4,7), (4, 8), (4, 9),
                    (9, 2), (9, 5),
                    (19, 4)
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                delete from CategoryProduct where (CategoryId, ProductId) in (
                    (4, 1), (4, 3), (4, 6), (4,7), (4, 8), (4, 9),
                    (9, 2), (9, 5),
                    (19, 4)
                )
            ");
        }
    }
}
