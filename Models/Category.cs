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
    public class Category : NestedSet<Category>
    {
        [Key]
        public override int Id { get; set; }

        [Required]
        public override int Lft { get; set; }

        [Required]
        public override int Rgt { get; set; }

        [Required]
        public override string Name { get; set; }

        [Required]
        public override int ParentId { get; set; }

        [Required]
        public override int Level { get; set; }

        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}