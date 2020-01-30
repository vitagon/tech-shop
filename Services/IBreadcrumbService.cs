using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Services
{
    public interface IBreadcrumbService
    {
        List<Breadcrumb> GetBreadcrumbTreeAsList(int categoryId);
    }
}
