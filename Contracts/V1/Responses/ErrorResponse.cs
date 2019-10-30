using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Contracts.V1.Responses
{
    public class ErrorResponse
    {
        public string Type { get; set; }
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
        public int Status { get; set; }
    }
}
