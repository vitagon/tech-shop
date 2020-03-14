using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Views;

namespace TechShop.Services
{
    public interface IProductFilterService
    {
        Task<List<Vw_CategoryProduct>> GetCategoryProducts(string categoryUrl);
    }
}
