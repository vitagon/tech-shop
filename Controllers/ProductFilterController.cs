using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/product-filters")]
    public class ProductFilterController : Controller
    {
        [HttpGet]
        public void GetFilters()
        {
            
        }
    }
}
