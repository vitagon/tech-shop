using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public abstract class NestedSet<T>
    {
        public abstract int Id { get; set; }
        public abstract int Lft { get; set; }
        public abstract int Rgt { get; set; }
        public abstract string Name { get; set; }
        public abstract int ParentId { get; set; }
        public abstract int Level { get; set; }

        [NotMapped]
        public SortedDictionary<int, T> Children { get; set; }
        [NotMapped]
        public List<T> ChildrenList { get; set; }
    }
}
