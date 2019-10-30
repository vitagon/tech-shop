using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TechShop.Contracts.V1.Responses;
using TechShop.Data;
using TechShop.Models;
using TechShop.Utilities.Attributes;

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
        
        [HttpPut("{id}")]
        public ActionResult UpdateCategory([Min(0)] int id, [FromBody] Category categoryDto)
        {
            
            var result = from i in _context.Category
                         where i.Id == id
                         select i;

            Category category = result.SingleOrDefault();

            if (category == null)
            {
                return new BadRequestObjectResult(new ErrorResponse()
                {
                    Type = "Entity not found",
                    Errors = new List<ErrorModel>()
                    {
                        new ErrorModel()
                        {
                            FieldName = "id",
                            Messages = new List<string>() {"Entity with such id was not found!"}
                        }
                    },
                    Status = 400
                });
            }

            
            categoryDto.Id = id;
            _context.Entry(category).State = EntityState.Detached;
            _context.Category.Update(categoryDto);
            _context.SaveChanges();
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _context.Category.Remove(new Category { Id = id });
            _context.SaveChanges();
        }
    }
}
