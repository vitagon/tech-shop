using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechShop.Installers
{
    public class CorsInstaller : IInstaller
    {
        public static readonly string _myAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(_myAllowSpecificOrigins,
                builder =>
                {
                  builder
                    .WithOrigins("http://localhost:3000", "https://localhost:5001");
                      //.AllowAnyHeader()
                      //.AllowAnyMethod()
                      //.AllowCredentials();
                });
            });
        }
    }
}
