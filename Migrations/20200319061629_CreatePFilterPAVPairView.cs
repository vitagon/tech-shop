using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreatePFilterPAVPairView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_PFilterPAVPair
                AS
                SELECT
                    pf.Id as FilterId, pfn.FilterName, pfv.FilterValue,
                    pavpair.Id AS PAVPairId, pattr.[Name] AS AttributeName, pval.[Value] AS AttributeValue
                FROM PFilter pf
                JOIN PFilterName pfn ON pf.PFilterNameId = pfn.Id
                JOIN PFilterValue pfv ON pf.PFilterValueId = pfv.Id
                JOIN PFilterPAVPair pfpavpair ON pf.Id = pfpavpair.PFilterId
                JOIN PAVPair pavpair ON pfpavpair.PAVPairId = pavpair.Id
                JOIN PAttribute pattr ON pavpair.PAttributeId = pattr.Id
                JOIN PValue pval ON pavpair.PValueId = pval.Id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_PFilterPAVPair");
        }
    }
}
