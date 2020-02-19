using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateAddCategoryByParentNameProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE AddCategoryByParentName
                    @Name nvarchar(450),
                    @ParentName nvarchar(450)
                AS
                BEGIN
	                declare @ParentId int,
                            @ParentLvl int,
                            @CategoryUrl nvarchar(450),
                            @NewLft int,
                            @LastInsertedId int;
                    set @CategoryUrl = LOWER(TRIM(@Name));
                    set @CategoryUrl = REPLACE(@CategoryUrl, ' ', '-');
	                select @NewLft = Rgt, @ParentId = Id, @ParentLvl = Level
                        from Category where Name = @ParentName;
	
	                update Category set Rgt = Rgt + 2 where Rgt >= @NewLft;
	                update Category set Lft = Lft + 2 where Lft > @NewLft;
	                insert into Category (Lft, Rgt, [Name], ParentId, Level, Url)
                        values (@NewLft, @NewLft + 1, @Name, @ParentId, @ParentLvl + 1, @CategoryUrl);
	
	                SELECT @LastInsertedId = Id FROM Category WHERE Id = @@Identity;
	                return @LastInsertedId;
                END;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS AddCategoryByParentName");
        }
    }
}
