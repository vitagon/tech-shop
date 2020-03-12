using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lft = table.Column<int>(nullable: false),
                    Rgt = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false, maxLength: 450),
                    ParentId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: false, maxLength: 450)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.UniqueConstraint("UQ_Category_Name", x => x.Name);
                    table.UniqueConstraint("UQ_Category_Url", x => x.Url);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
