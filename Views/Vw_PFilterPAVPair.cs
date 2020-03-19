using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Views
{
    public class Vw_PFilterPAVPair
    {
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string FilterValue { get; set; }
        public int PAVPairId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
    }
}
