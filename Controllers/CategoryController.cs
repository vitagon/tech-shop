using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TechShop.Contracts.V1.Responses;
using TechShop.Models;
using TechShop.Services;
using TechShop.Utilities.Attributes;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_categoryService.GetCategoriesAsync());
        }

        [HttpGet("tree")]
        public async Task<IActionResult> GetCategoriesTree([FromQuery] int parentId)
        {
            if (parentId != 0)
            {
                return Ok(_categoryService.GetTreeFromNode(parentId));
            }

            List<Category> cats = await _categoryService.GetTreeFromRoot();
            return Ok(cats);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetCategoryByName(string name)
        {
            Category category = await _categoryService.GetCategoryByNameAsync(name);
            if (category == null) {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult SaveCategory([FromBody] Category category)
        {
            return Created("/api/categories", _categoryService.CreateCategoryAsync(category));
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([Min(0)] int id, [FromBody] Category categoryDto)
        {
            Category category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return BadRequest(new ErrorResponse()
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
            await _categoryService.UpdateCategoryAsync(categoryDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async void DeleteCategory([Min(0)] int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
        }
    }
}
