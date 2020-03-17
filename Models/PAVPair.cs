using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PAVPair")]
    public class PAVPair
    {
        [Key]
        public int Id { get; set; }

        
        public virtual PAttribute PAttribute { get; set; }

        [ForeignKey("PAttribute")]
        public int AttributeId { get; set; }

        public virtual PValue PValue { get; set; }

        [ForeignKey("PValue")]
        public int ValueId { get; set; }
    }
}
