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
        public string Name { get; set; }

        [Required]
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