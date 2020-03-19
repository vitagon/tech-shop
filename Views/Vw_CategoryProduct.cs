using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Views
{
    public class Vw_CategoryProduct
    {
        // Product
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductImg { get; set; }

        public int ProductBrandId { get; set; }

        [Column(TypeName = "decimal(3,1)")]
        public decimal ProductRating { get; set; }


        // Category
        public int CatId { get; set; }

        public string CatName { get; set; }

        public int ParentId { get; set; }

        public int CatLevel { get; set; }

        public string CatUrl { get; set; }
    }
}
