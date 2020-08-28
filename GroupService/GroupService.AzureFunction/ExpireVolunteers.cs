using System;
using System.Threading;
using System.Threading.Tasks;
using GroupService.Core.Config;
using GroupService.Core.Interfaces.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GroupService.AzureFunction
{
    public class ExpireVolunteers
    {
        private readonly IExpiredService _expiredService;
        private readonly IOptionsSnapshot<ApplicationConfig> _applicationConfig;

        public ExpireVolunteers(IExpiredService expiredService, IOptionsSnapshot<ApplicationConfig> applicationConfig)
        {
            _expiredService = expiredService;
            _applicationConfig = applicationConfig;
        }

        [FunctionName("ExpireVolunteers")]
        public async Task Run([TimerTrigger("%ExpireVolunteersCronExpression%")] TimerInfo timerInfo, ILogger log, CancellationToken cancellationToken)
        {
            log.LogInformation($"ExpireVolunteers started at: {DateTime.Now}");
            int expiredVolunteerDays = _applicationConfig.Value.ExpiredVolunteerDays;
            await _expiredService.ExpireVolunteers(expiredVolunteerDays, cancellationToken);
            log.LogInformation($"ExpireVolunteers finished at: {DateTime.Now}");
        }
    }
}
