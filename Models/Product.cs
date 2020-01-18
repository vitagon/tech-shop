using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public int OldPrice { get; set; }
        
        public int Sale { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}
