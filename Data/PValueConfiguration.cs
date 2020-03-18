using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class PValueConfiguration : IEntityTypeConfiguration<PValue>
    {
        public void Configure(EntityTypeBuilder<PValue> builder)
        {
            builder.HasIndex(x => x.Value).IsUnique();

            builder.HasData(
                // RAM
                new PValue { Id = 1, Value = "2 GB" },
                new PValue { Id = 2, Value = "4 GB" },
                new PValue { Id = 3, Value = "6 GB" },
                new PValue { Id = 4, Value = "8 GB" },
                new PValue { Id = 5, Value = "12 GB" },
                new PValue { Id = 6, Value = "16 GB" },
                new PValue { Id = 7, Value = "24 GB" },
                new PValue { Id = 8, Value = "32 GB" },
                new PValue { Id = 9, Value = "64 GB" },

                // HDD Size
                new PValue { Id = 10, Value = "None" },
                new PValue { Id = 11, Value = "500 GB" },
                new PValue { Id = 12, Value = "1000 GB" },
                new PValue { Id = 13, Value = "1500 GB" },
                new PValue { Id = 14, Value = "2000 GB" },
                new PValue { Id = 15, Value = "2500 GB" },

                // SSD Size
                new PValue { Id = 16, Value = "128 GB" },
                new PValue { Id = 17, Value = "180 GB" },
                new PValue { Id = 18, Value = "256 GB" },
                new PValue { Id = 19, Value = "512 GB" },
                new PValue { Id = 20, Value = "1024 GB" },

                // Display Size
                new PValue { Id = 21, Value = "11\"" },
                new PValue { Id = 22, Value = "11.6\"" },
                new PValue { Id = 23, Value = "12\"" },
                new PValue { Id = 24, Value = "12.5\"" },
                new PValue { Id = 25, Value = "13.3\"" },
                new PValue { Id = 26, Value = "14\"" },
                new PValue { Id = 27, Value = "15.6\"" },
                new PValue { Id = 28, Value = "17.3\"" },

                // Display Resolution
                new PValue { Id = 29, Value = "1366x768" },
                new PValue { Id = 30, Value = "1366x912" },
                new PValue { Id = 31, Value = "1440x900" },
                new PValue { Id = 32, Value = "1600x900" },
                new PValue { Id = 33, Value = "1920x1080" },
                new PValue { Id = 34, Value = "2160x1440" },
                new PValue { Id = 35, Value = "2304x1440" },
                new PValue { Id = 36, Value = "2560x1600" },
                new PValue { Id = 37, Value = "2880x1800" },
                new PValue { Id = 38, Value = "3000x2000" },
                new PValue { Id = 39, Value = "3072x1920" },
                new PValue { Id = 40, Value = "3200x1800" },
                new PValue { Id = 41, Value = "3840x2160" },

                // Processor Type
                new PValue { Id = 42, Value = "Intel Core i9" },
                new PValue { Id = 43, Value = "Intel Core i7" },
                new PValue { Id = 44, Value = "Intel Core i5" },
                new PValue { Id = 45, Value = "Intel Core i3" },
                new PValue { Id = 46, Value = "Intel Xeon" },
                new PValue { Id = 47, Value = "Intel Core M7" },
                new PValue { Id = 48, Value = "Intel Core M5" },
                new PValue { Id = 49, Value = "Intel Core M3" },
                new PValue { Id = 50, Value = "Intel Pentium" },
                new PValue { Id = 51, Value = "Intel Celeron" },
                new PValue { Id = 52, Value = "Intel Atom" },
                new PValue { Id = 53, Value = "AMD Razen 7" },
                new PValue { Id = 54, Value = "AMD Razen 5" },
                new PValue { Id = 55, Value = "AMD Razen 3" },
                new PValue { Id = 56, Value = "AMD A9" },

                // Number of CPU Cores
                new PValue { Id = 57, Value = "2" },
                new PValue { Id = 58, Value = "4" },
                new PValue { Id = 59, Value = "6" },
                new PValue { Id = 60, Value = "8" },

                // Operating System
                new PValue { Id = 61, Value = "Windows 10 Home" },
                new PValue { Id = 62, Value = "Windows 10 Professional" },
                new PValue { Id = 63, Value = "UNIX" },
                new PValue { Id = 64, Value = "Chrome OS" },
                new PValue { Id = 65, Value = "MacOS" },

                // Graphics Type
                new PValue { Id = 66, Value = "Integrated" },
                new PValue { Id = 67, Value = "Dedicated & Integrated" },

                // Graphics Processor
                new PValue { Id = 68, Value = "GeForce RTX 2080" },
                new PValue { Id = 69, Value = "GeForce RTX 2080 MaxQ" },
                new PValue { Id = 70, Value = "GeForce RTX 2070" },
                new PValue { Id = 71, Value = "GeForce RTX 2070 MaxQ" },
                new PValue { Id = 72, Value = "Radeon 540X" },
                new PValue { Id = 73, Value = "GeForce MX250" },
                new PValue { Id = 74, Value = "GeForce MX230" },

                // Graphics Brand
                new PValue { Id = 75, Value = "AMD" },
                new PValue { Id = 76, Value = "Intel" },
                new PValue { Id = 77, Value = "nVidia" }
                );
        }
    }
}
