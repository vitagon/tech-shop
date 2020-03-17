using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PFilterPAVPair")]
    public class PFilterPAVPair
    {

        public PFilter PFilter { get; set; }

        [Key, Column(Order = 0), ForeignKey("PFilter")]
        public int FilterId { get; set; }

        public PAVPair PAVPair { get; set; }

        [Key, Column(Order = 1), ForeignKey("PAVPair")]
        public int AVPairId { get; set; }
    }
}
