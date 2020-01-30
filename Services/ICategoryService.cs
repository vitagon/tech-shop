using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> GetCategoryByNameAsync(string name);
        Task<Category> GetCategoryByUrlAsync(string url);
        Task<bool> CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(int id);
        Task<List<Category>> GetTreeFromRoot();
        Task<List<Category>> GetTreeFromNode(int parentId);
    }
}
