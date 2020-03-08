using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class CreateProductPAVPairView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW vw_ProductPAVPair
                AS
                SELECT
                    p.Id, p.[Name], p.[Description], p.Img, p.Price, p.OldPrice, p.Sale, p.Rating,
	                vw_pav_pair.Id as PairId, vw_pav_pair.Id as AttrId, vw_pav_pair.[Name] as AttrName, vw_pav_pair.Id as ValId, vw_pav_pair.[Value]
                FROM vw_PAVPair vw_pav_pair
                JOIN ProductPAVPair product_pav_pair ON product_pav_pair.AVPairId = vw_pav_pair.PairId
                JOIN Product p ON product_pav_pair.ProductId = p.Id;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS vw_ProductPAVPair");
        }
    }
}
