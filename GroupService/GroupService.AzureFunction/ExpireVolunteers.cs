using System;
using System.Threading;
using System.Threading.Tasks;
using GroupService.Core.Interfaces.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace GroupService.AzureFunction
{
    public class ExpireVolunteers
    {
        private readonly IExpiredService _expiredService;

        public ExpireVolunteers(IExpiredService expiredService)
        {
            _expiredService = expiredService;
        }

        [FunctionName("ExpireVolunteers")]
        public async Task Run([TimerTrigger("%ExpireVolunteersCronExpression%",RunOnStartup =true)] TimerInfo timerInfo, ILogger log, CancellationToken cancellationToken)
        {
            log.LogInformation($"ExpireVolunteers started at: {DateTime.Now}");
            await _expiredService.ExpireVolunteers(cancellationToken);
            log.LogInformation($"ExpireVolunteers finished at: {DateTime.Now}");
        }
    }
}
