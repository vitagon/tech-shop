using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TechShop.Data;
using TechShop.Models;

namespace TechShop.Controllers
{
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

        public IQueryable<Category> GetCategories()
        {
            var result = from i in _context.Category
                         select i;
            return result;
        }
    }
}
