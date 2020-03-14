using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Views
{
    public class Vw_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public decimal Rating { get; set; }

        public int PriceId { get; set; }
        public string PriceDescription { get; set; }
        public DateTime PriceStartDate { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }

        public int DiscountId { get; set; }
        public DateTime DiscountStartDate { get; set; }
        public DateTime DiscountEndDate { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
