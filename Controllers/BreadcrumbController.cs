using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Contracts.V1.Responses;
using TechShop.Models;
using TechShop.Services;

namespace TechShop.Controllers
{
    [ApiController]
    [Route("/api/breadcrumbs")]
    public class BreadcrumbController : Controller
    {
        private IBreadcrumbService breadcrumbService;
        private ICategoryService categoryService;

        public BreadcrumbController(IBreadcrumbService breadcrumbService, ICategoryService categoryService)
        {
            this.breadcrumbService = breadcrumbService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<BreadcrumbResponse>> GetBreadcrumbList()
        {
            List<BreadcrumbResponse> breadcrumbResponseList = new List<BreadcrumbResponse>();

            Category category = await categoryService.GetCategoryByUrlAsync("");

            List<Breadcrumb> breadcrumbList = breadcrumbService.GetBreadcrumbTreeAsList(category.Id);
            foreach (Breadcrumb b in breadcrumbList)
            {
                BreadcrumbResponse breadcrumbResponse = new BreadcrumbResponse();
                breadcrumbResponse.Id = b.Id;
                breadcrumbResponse.Name = b.Name;
                breadcrumbResponse.ParentId = b.ParentId;
                breadcrumbResponse.Url = b.Url;
                breadcrumbResponseList.Add(breadcrumbResponse);
            }

            return breadcrumbResponseList;
        }

        [HttpGet("{categoryUrl}")]
        public async Task<List<BreadcrumbResponse>> GetBreadcrumbList(string categoryUrl)
        {
            List<BreadcrumbResponse> breadcrumbResponseList = new List<BreadcrumbResponse>();

            Category category = await categoryService.GetCategoryByUrlAsync(categoryUrl);

            List<Breadcrumb> breadcrumbList = breadcrumbService.GetBreadcrumbTreeAsList(category.Id);
            foreach (Breadcrumb b in breadcrumbList)
            {
                BreadcrumbResponse breadcrumbResponse = new BreadcrumbResponse();
                breadcrumbResponse.Id = b.Id;
                breadcrumbResponse.Name = b.Name;
                breadcrumbResponse.ParentId = b.ParentId;
                breadcrumbResponse.Url = b.Url;
                breadcrumbResponseList.Add(breadcrumbResponse);
            }

            return breadcrumbResponseList;
        }
    }
}
