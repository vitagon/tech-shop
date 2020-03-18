using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class PFilter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PFilterNameId { get; set; }
        [Required]
        public int PFilterValueId { get; set; }


        public virtual PFilterName PFilterName { get; set; }
        public virtual PFilterValue PFilterValue { get; set; }
    }
}
