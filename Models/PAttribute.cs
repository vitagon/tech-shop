using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PAttribute")]
    public class PAttribute
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(450)]
        public string Name { get; set; }
    }
}
