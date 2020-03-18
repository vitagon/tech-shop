using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PFilterConfiguration : IEntityTypeConfiguration<PFilter>
    {
        public void Configure(EntityTypeBuilder<PFilter> builder)
        {
            builder.HasIndex(x => new { x.PFilterNameId, x.PFilterValueId }).IsUnique();

            builder.HasData(
                // RAM Filter
                new PFilter { Id = 1, PFilterNameId = 1, PFilterValueId = 1 },
                new PFilter { Id = 2, PFilterNameId = 1, PFilterValueId = 2 },
                new PFilter { Id = 3, PFilterNameId = 1, PFilterValueId = 3 },
                new PFilter { Id = 4, PFilterNameId = 1, PFilterValueId = 4 },
                new PFilter { Id = 5, PFilterNameId = 1, PFilterValueId = 5 },
                new PFilter { Id = 6, PFilterNameId = 1, PFilterValueId = 6 },

                // SSD Size Filter
                new PFilter { Id = 7, PFilterNameId = 2, PFilterValueId = 7 },
                new PFilter { Id = 8, PFilterNameId = 2, PFilterValueId = 8 },
                new PFilter { Id = 9, PFilterNameId = 2, PFilterValueId = 9 },

                // Operating System Filter
                new PFilter { Id = 10, PFilterNameId = 3, PFilterValueId = 10 },
                new PFilter { Id = 11, PFilterNameId = 3, PFilterValueId = 11 },
                new PFilter { Id = 12, PFilterNameId = 3, PFilterValueId = 12 }
                );
        }
    }
}
