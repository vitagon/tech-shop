using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class PFilterPAVPair
    {
        [Key]
        public int PFilterId { get; set; }
        [Key]
        public int PAVPairId { get; set; }


        public virtual PFilter PFilter { get; set; }
        public virtual PAVPair PAVPair { get; set; }
    }
}
