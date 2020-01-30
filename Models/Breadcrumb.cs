using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class Breadcrumb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Level { get; set; }
        public int ParentId { get; set; }
        public string Url { get; set; }
    }
}
