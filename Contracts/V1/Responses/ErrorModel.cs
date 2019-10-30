using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Contracts.V1.Responses
{
    public class ErrorModel
    {
        public string FieldName { get; set; }
        public List<string> Messages { get; set; }
    }
}
