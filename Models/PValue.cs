using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PValue")]
    public class PValue
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(450)]
        public string Value { get; set; }
    }
}
