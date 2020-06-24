using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LinhKienNH.Data.EF
{
    public class LinhKienNHSolutionFactory : IDesignTimeDbContextFactory<ShopDbContext>
    {
       
        ShopDbContext IDesignTimeDbContextFactory<ShopDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            

            var connectionString = configuration.GetConnectionString("ShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ShopDbContext(optionsBuilder.Options);
        }
    }
}
