using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Services;
using TechShop.Views;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/product-filters")]
    public class ProductFilterController : Controller
    {
        public IProductFilterService productFilterService;

        public ProductFilterController(IProductFilterService productFilterService)
        {
            this.productFilterService = productFilterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFilters(string categoryUrl)
        {
            return Ok(await productFilterService.GetCategoryProducts(categoryUrl));
        }
    }
}
