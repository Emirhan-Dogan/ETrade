using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeServer.Persistence.Concrete.EntityFramework.Contexts;
using Microsoft.Extensions.Configuration;

namespace ETradeServer.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETradeServerDBContext>
    {
        public ETradeServerDBContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(
                Path.Combine(
                    Directory.GetCurrentDirectory(), 
                    "../../Presentation/ETradeService.WebAPI")
                );
            configurationManager.AddJsonFile("appsettings.json");
            
            DbContextOptionsBuilder<ETradeServerDBContext> eTradeServerDBContextOptions = new DbContextOptionsBuilder<ETradeServerDBContext>();
            eTradeServerDBContextOptions.UseNpgsql(configurationManager.GetConnectionString("PostgreSQL"));


            return new ETradeServerDBContext(eTradeServerDBContextOptions.Options);
        }
    }
}
