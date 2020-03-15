using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("ProductPAVPair")]
    public class ProductPAVPair
    {
        
        public virtual Product Product { get; set; }

        [Key, Column(Order = 0), ForeignKey("Product")]
        public int ProductId { get; set; }

        
        public virtual PAVPair PAVPair { get; set; }

        [Key, Column(Order = 1), ForeignKey("PAVPair")]
        public int AVPairId { get; set; }
    }
}
