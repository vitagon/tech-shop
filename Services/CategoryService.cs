using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Data;
using TechShop.Models;

namespace TechShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly TechDbContext techDbContext;

        public CategoryService(TechDbContext techDbContext)
        {
            this.techDbContext = techDbContext;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await techDbContext.Category.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await techDbContext.Category.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            await techDbContext.Category.AddAsync(category);
            var created = await techDbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            techDbContext.Category.Update(category);
            var updated = await techDbContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await GetCategoryByIdAsync(id);
            techDbContext.Category.Remove(category);
            var deleted = await techDbContext.SaveChangesAsync();
            return deleted > 0; 
        }
    }
}
