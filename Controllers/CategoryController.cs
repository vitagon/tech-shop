using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TechShop.Data;
using TechShop.Models;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    public class CategoryController
    {

        private readonly IConfiguration configuration;
        private TechDbContext _context;

        public CategoryController(IConfiguration configuration, TechDbContext context)
        {
            this.configuration = configuration;
            this._context = context;
        }

        public List<string> Index()
        {
            List<string> categories = new List<string>();
            string connectionString = configuration.GetConnectionString("TechShopContext");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from categories", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(reader["name"].ToString());
            }
            connection.Close();
            return categories;
        }

        [HttpGet]
        public IQueryable<Category> GetCategories()
        {
            var result = from i in _context.Category
                         select i;
            return result;
        }

        [HttpGet("name/{name}")]
        public IActionResult GetCategoryByName(string name)
        {
            var result = from i in _context.Category
                         where i.Name == name
                         select i;
            
            Category category = result.SingleOrDefault();
            if (category == null) {
              return new NotFoundResult();
            }
            return new OkResult();
        }

        [HttpPost]
        public Category SaveCategory([FromBody] Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
            return category;
        }

        [HttpPut]
        public void UpdateCategory([FromBody] Category category)
        {
            if (category.Id == 0) {
                throw new Exception("Id property is required!");
            }
            _context.Category.Update(category);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _context.Category.Remove(new Category { Id = id });
            _context.SaveChanges();
        }
    }
}
