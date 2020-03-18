using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class ProductDiscount
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int DiscountId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
