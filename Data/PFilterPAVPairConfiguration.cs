using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PFilterPAVPairConfiguration : IEntityTypeConfiguration<PFilterPAVPair>
    {
        public void Configure(EntityTypeBuilder<PFilterPAVPair> builder)
        {
            builder.HasKey(x => new { x.PFilterId, x.PAVPairId });

            builder.HasData(
                // RAM
                new PFilterPAVPair { PFilterId = 1, PAVPairId = 1 },
                new PFilterPAVPair { PFilterId = 2, PAVPairId = 2 },
                new PFilterPAVPair { PFilterId = 3, PAVPairId = 3 },
                new PFilterPAVPair { PFilterId = 4, PAVPairId = 4 },
                new PFilterPAVPair { PFilterId = 5, PAVPairId = 5 },
                new PFilterPAVPair { PFilterId = 6, PAVPairId = 6 },

                // SSD 128 to 256 GB
                new PFilterPAVPair { PFilterId = 7, PAVPairId = 16 },
                new PFilterPAVPair { PFilterId = 7, PAVPairId = 17 },
                new PFilterPAVPair { PFilterId = 7, PAVPairId = 18 },

                // SSD (257 to 512 GB) (513 to 1024 GB)
                new PFilterPAVPair { PFilterId = 8, PAVPairId = 19 },
                new PFilterPAVPair { PFilterId = 9, PAVPairId = 20 },

                // Operating System (Windows -> Windows Home, Windows Professional)
                new PFilterPAVPair { PFilterId = 10, PAVPairId = 61 },
                new PFilterPAVPair { PFilterId = 10, PAVPairId = 62 },

                // Operating System (MacOS and UNIX)
                new PFilterPAVPair { PFilterId = 11, PAVPairId = 65 },
                new PFilterPAVPair { PFilterId = 12, PAVPairId = 63 }
                );
        }
    }
}
