using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    [Table("PFilter")]
    public class PFilter
    {
        [Key]
        public int Id { get; set; }

        public PFilterName PFilterName { get; set; }
        public int PFilterNameId { get; set; }

        public PFilterValue PFilterValue { get; set; }
        public int PFilterValueId { get; set; }
    }
}
