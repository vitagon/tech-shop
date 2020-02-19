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
        public decimal UpPrice { get; set; }
        public decimal DownPrice { get; set; }
    }
}
