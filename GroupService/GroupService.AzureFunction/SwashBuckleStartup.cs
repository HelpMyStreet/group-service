using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using GroupService.AzureFunction;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(SwashBuckleStartup))]
namespace GroupService.AzureFunction
{
    internal class SwashBuckleStartup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());
        }
    }
}
