using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Models;

namespace TechShop.Services
{
    public class BreadcrumbService : IBreadcrumbService
    {
        private readonly TechDbContext techDbContext;

        public BreadcrumbService(TechDbContext techDbContext)
        {
            this.techDbContext = techDbContext;
        }

        public List<Breadcrumb> GetBreadcrumbTreeAsList(int categoryId)
        {
            //List<Breadcrumb> breadcrumbs = techDbContext.Breadcrumb.FromSqlRaw("GetCategoryPath @p0", categoryId).ToList();
            //return breadcrumbs;
            return new List<Breadcrumb>();
        }
    }
}
