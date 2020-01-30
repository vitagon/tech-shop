using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Contracts.V1.Responses
{
    public class BreadcrumbResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
