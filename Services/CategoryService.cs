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
        private readonly TechDbContext _techDbContext;

        public CategoryService(TechDbContext techDbContext)
        {
            this._techDbContext = techDbContext;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var result = from i in _techDbContext.Category
                         select i;
            return await result.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            //return await techDbContext.Category.SingleOrDefaultAsync(x => x.Id == id);
            var result = from i in _techDbContext.Category
                         where i.Id == id
                         select i;
            Category category = await result.SingleOrDefaultAsync();
            detach(category);
            return category;
        }

        public async Task<Category> GetCategoryByNameAsync(string name)
        {
            var result = from i in _techDbContext.Category
                         where i.Name == name
                         select i;
            Category category = await result.SingleOrDefaultAsync();
            detach(category);
            return category;
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.Id = 0;
            await _techDbContext.Category.AddAsync(category);
            var created = await _techDbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            _techDbContext.Category.Update(category);
            var updated = await _techDbContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await GetCategoryByIdAsync(id);
            _techDbContext.Category.Remove(category);
            var deleted = await _techDbContext.SaveChangesAsync();
            return deleted > 0;
        }

        private void detach(Category category)
        {
            _techDbContext.Entry(category).State = EntityState.Detached;
        }

        public async Task<List<Category>> GetTreeFromRoot()
        {
            List<Category> categories = await _techDbContext.Category.ToListAsync();
            List<Category> catsListCopy = new List<Category>(categories);
            //return nestedSetService.BuildTreeAsList(ref catsListCopy);
            return new List<Category>();
        }

        public async Task<List<Category>> GetTreeFromNode(int parentId)
        {
            //var getParentNode = from c in _techDbContext.Category
            //                    where c.Id == parentId
            //                    select c;
            //Category parentNode = await getParentNode.FirstOrDefaultAsync();

            //var query = from c in _techDbContext.Category
            //            where c.Lft >= parentNode.Lft && c.Rgt <= parentNode.Rgt
            //            select c;
            //List<Category> categories = await query.ToListAsync();

            //List<Category> categoriesCopy = new List<Category>(categories);
            //return nestedSetService.BuildTreeAsList(ref categoriesCopy, parentNode.ParentId);
            return new List<Category>();
        }

        public async Task<Category> GetCategoryByUrlAsync(string url)
        {
            var result = from c in _techDbContext.Category
                         where c.Url == url
                         select c;
            Category category = await result.SingleOrDefaultAsync();
            detach(category);
            return category;
        }
    }
}
