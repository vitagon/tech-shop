using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Views;

namespace TechShop.Services
{
    public class ProductFilterService : IProductFilterService
    {
        private readonly TechDbContext techDbContext;

        public ProductFilterService(TechDbContext techDbContext)
        {
            this.techDbContext = techDbContext;
        }

        public async Task<List<Vw_CategoryProducts>> GetCategoryProducts(string categoryUrl)
        {
            IQueryable<Vw_CategoryProducts> req = techDbContext.Vw_CategoryProducts;

            if (categoryUrl != null)
            {
                req = req.Where(x => x.CatUrl == categoryUrl);
                return await req.ToListAsync();
            }
            return await req.ToListAsync();
        }
    }
}
