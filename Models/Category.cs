using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Utilities.Attributes;

namespace TechShop.Models
{
    [Table("categories")]
    public class Category
    {
        [Required, Key]
        [Range(1, Int32.MaxValue)]
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "{0} length must be between {2} and {1}")]
        public string Name { get; set; }

        [Required, Column("parent_id")]
        [Min(0, ErrorMessage = "{0} must be more or equal to 0")]
        public int ParentId { get; set; }

        public override string ToString()
        {
            string str = String.Empty;
            str = String.Concat(str, "Id = ", Id, "\r\n");
            str = String.Concat(str, "Name = ", Name, "\r\n");
            str = String.Concat(str, "ParentId = ", ParentId, "\r\n");
            return str;
        }
    }
}