using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Models;
using TechShop.Services;
using TechShop.Views;

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
        public IActionResult GetProducts([FromQuery] ProductFilters productFilters)
        {
            var fetchProducts = from p in _techDbContext.Vw_Product
                                select p;

            if (productFilters.CategoryUrl != null)
            {
                fetchProducts = from p in fetchProducts
                                join cp in _techDbContext.CategoryProduct on p.Id equals cp.ProductId
                                join c in _techDbContext.Category on cp.CategoryId equals c.Id
                                where c.Url == productFilters.CategoryUrl
                                select p;
            }

            if (productFilters.CategoryName != null)
            {
                fetchProducts = from p in fetchProducts
                                join cp in _techDbContext.CategoryProduct on p.Id equals cp.ProductId
                                join c in _techDbContext.Category on cp.CategoryId equals c.Id
                                where c.Name == productFilters.CategoryName
                                select p;
            }

            if (productFilters.MaxPrice > 0)
            {
                fetchProducts = from p in fetchProducts
                                where p.Price <= productFilters.MaxPrice
                                select p;
            }

            if (productFilters.MinPrice > 0)
            {
                fetchProducts = from p in fetchProducts
                                where p.Price >= productFilters.MinPrice
                                select p;
            }

            PagedList<Vw_Product> products = PagedList<Vw_Product>.ToPagedList(
                fetchProducts,
                productFilters.PageNumber,
                productFilters.PageSize);

            var metadata = new
            {
                products.TotalCount,
                products.PageSize,
                products.CurrentPage,
                products.TotalPages,
                products.HasNext,
                products.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return Ok(products);
        }
    }
}
