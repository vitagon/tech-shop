using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Views
{
    public class Vw_CategoryProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public int Sale { get; set; }
        public decimal Rating { get; set; }

        public string CatId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public string CatName { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public string Url { get; set; }
    }
}
