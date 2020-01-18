using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Utilities.Attributes;

namespace TechShop.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Lft { get; set; }

        [Required]
        public int Rgt { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ParentId { get; set; }

        [Required]
        public int Level { get; set; }

        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}