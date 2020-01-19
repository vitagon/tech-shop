using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Models;
using TechShop.Services;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : Controller
    {
        private readonly TechDbContext _techDbContext;

        public ProductController(TechDbContext techDbContext)
        {
            _techDbContext = techDbContext;
        }

        [HttpGet]
        public IActionResult getProducts([FromQuery] ProductFilters productFilters)
        {
            var fetchProducts = from p in _techDbContext.Product
                                select p;

            if (productFilters.CategoryName != null)
            {
                fetchProducts = from p in fetchProducts
                                join cp in _techDbContext.CategoryProduct on p.Id equals cp.ProductId
                                join c in _techDbContext.Category on cp.CategoryId equals c.Id
                                where c.Name == productFilters.CategoryName
                                select p;
            }

            if (productFilters.UpPrice > 0)
            {
                fetchProducts = from p in fetchProducts
                                where p.Price <= productFilters.UpPrice
                                select p;
            }

            if (productFilters.DownPrice > 0)
            {
                fetchProducts = from p in fetchProducts
                                where p.Price >= productFilters.DownPrice
                                select p;
            }

            List<Product> products = fetchProducts.Take(100).ToList();
            return Ok(products);
        }
    }
}
