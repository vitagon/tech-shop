using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechShop.Installers
{
    public class SpaInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "ClientApp/build";
            });
        }
    }
}
