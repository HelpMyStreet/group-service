using AutoMapper;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using GroupService.Mappers;
using GroupService.Repo;
using MediatR;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

[assembly: FunctionsStartup(typeof(GroupService.AzureFunction.Startup))]
namespace GroupService.AzureFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddMediatR(typeof(FunctionAHandler).Assembly);
            builder.Services.AddAutoMapper(typeof(AddressDetailsProfile).Assembly);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseInMemoryDatabase(databaseName: "GroupService.AzureFunction"));
            builder.Services.AddTransient<IRepository, Repository>();
        }
    }
}