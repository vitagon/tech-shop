using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Views
{
    public class Vw_CategoryProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OldPrice { get; set; }

        public int Sale { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        public int CatId { get; set; }

        public int Lft { get; set; }

        public int Rgt { get; set; }

        public string CatName { get; set; }

        public int ParentId { get; set; }

        public int Level { get; set; }

        public string CatUrl { get; set; }
    }
}
