using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Data
{
    public class TechDbContext : DbContext
    {
        public TechDbContext (DbContextOptions<TechDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
