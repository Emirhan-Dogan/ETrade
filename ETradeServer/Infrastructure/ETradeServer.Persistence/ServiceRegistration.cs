using ETradeServer.Persistence.Concrete.EntityFramework.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ETradeServer.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPresistanceServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(
                Path.Combine(
                    Directory.GetCurrentDirectory(), 
                    "../../Presentation/ETradeService.WebAPI"
                    ));
            configurationManager.AddJsonFile("appsettings.json");
            services.AddDbContext<ETradeServerDBContext>(
                options => options.UseNpgsql(
                    configurationManager.GetConnectionString("PostgreSQL")
                    ));
        }
    }
}
