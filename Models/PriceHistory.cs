using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PriceHistory")]
    public class PriceHistory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(450)]
        public string Description { get; set; }

        [Display(Name = "StartDate")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
