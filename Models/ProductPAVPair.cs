using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class ProductPAVPair
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int PAVPairId { get; set; }


        public virtual Product Product { get; set; }
        public virtual PAVPair PAVPair { get; set; }
    }
}
