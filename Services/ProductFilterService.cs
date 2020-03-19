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
        private readonly TechDbContext _techDbContext;

        public ProductFilterService(TechDbContext techDbContext)
        {
            this._techDbContext = techDbContext;
        }

        public async Task<List<Vw_CategoryProduct>> GetCategoryProducts(string categoryUrl)
        {
            //IQueryable<Vw_CategoryProduct> req = from categoryProduct in techDbContext.Vw_CategoryProducts
            //                                      select categoryProduct;

            //if (categoryUrl != null)
            //{
            //    req = req.Where(x => x.CatUrl == categoryUrl);
            //    return await req.ToListAsync();
            //}
            //return await req.ToListAsync();
            return new List<Vw_CategoryProduct>();
        }
    }
}
