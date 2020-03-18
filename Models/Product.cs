using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(450)]
        public string Name { get; set; }

        [Required]
        [MaxLength(450)]
        public string Description { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public int BrandId { get; set; }

        [Column(TypeName = "decimal(1,2)")]
        public decimal? Rating { get; set; }


        public virtual Brand Brand { get; set; }
        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscount { get; set; }
    }
}
