using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreatePAVPairView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_PAVPair
                AS
                SELECT
	                pav_pair.Id as PairId, pattr.Id, pattr.[Name], pval.Id as ValId, pval.[Value]
                FROM PAVPair pav_pair
                JOIN PAttribute pattr ON pav_pair.AttributeId = pattr.Id
                JOIN PValue pval ON pav_pair.ValueId = pval.Id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("@DROP VIEW IF EXISTS vw_PAVPair");
        }
    }
}
