using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateGetCategoryPathProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetCategoryPath
                    @Id int
                AS
                BEGIN
                    with tree (Id, ParentId, [Name], [Level], [Path], [Url])
	                as (
		                select c1.Id, c1.ParentId, c1.[Name], 0, cast(@Id as varchar), c1.[Url]
		                from Category c1 where c1.id = @Id
	
		                union all

		                select c2.Id, c2.ParentId, c2.[Name], t.[Level] + 1, cast(cast(c2.Id as varchar) + '-' + t.[Path] as varchar), c2.[Url]
		                from Category c2
		                join tree t on t.ParentId = c2.Id
	                )
	                select t.Id, t.[Name], t.[Path], t.[Level], t.ParentId, t.[Url] from tree t order by t.[Level] desc;
                END;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetCategoryPath");
        }
    }
}
