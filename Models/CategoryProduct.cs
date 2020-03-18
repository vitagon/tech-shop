using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("CategoryProduct")]
    public class CategoryProduct
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Key]
        public int ProductId { get; set; }


        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
