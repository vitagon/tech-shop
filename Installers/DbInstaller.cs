using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechShop.Data;
using TechShop.Services;

namespace TechShop.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TechDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TechShopContext")));
            //services.AddDbContext<TechDbContext>(options => options.UseSqlite("Filename=TechShop.db"));

            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
