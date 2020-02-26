using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class ProductFilters : QueryStringParameters
    {
        public string CategoryUrl { get; set; }
        public string CategoryName { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
    }
}
