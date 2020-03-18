using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class PAVPair
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PAttributeId { get; set; }
        [Required]
        public int PValueId { get; set; }


        public virtual PAttribute PAttribute { get; set; }
        public virtual PValue PValue { get; set; }   
    }
}
