using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;
using TechShop.Services;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;

        public ProductController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult getProducts()
        {
            return Ok();
        }
    }
}
