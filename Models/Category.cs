using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Utilities.Attributes;

namespace TechShop.Models
{
    public class Category
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [MaxLength(450)]
        public string Name { get; set; }

        public int? ParentId { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        [MaxLength(450)]
        public string Url { get; set; }


        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}