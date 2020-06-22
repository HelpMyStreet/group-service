using GroupService.Core.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GroupService.Repo
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // get connection string from AddressService.AzureFunction" project to avoid duplication
            string azureFunctionDirectory = Directory.GetCurrentDirectory().Replace("GroupService.Repo", "GroupService.AzureFunction");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(azureFunctionDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionStringSettings = configuration.GetSection("ConnectionStrings");
            var connectionStrings = new ConnectionStrings();
            connectionStringSettings.Bind(connectionStrings);

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionStrings.GroupService);

            Console.WriteLine($"Using following connection string for Entity Framework: {connectionStrings.GroupService}");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
