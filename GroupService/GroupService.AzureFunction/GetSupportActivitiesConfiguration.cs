using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.AspNetCore.Http;
using MediatR;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using Microsoft.Azure.WebJobs.Extensions.Http;
using HelpMyStreet.Utils.Extensions;
using System.Threading;
using HelpMyStreet.Utils.Utils;
using HelpMyStreet.Contracts.GroupService.Response;
using System.Net;
using AzureFunctions.Extensions.Swashbuckle.Attribute;

namespace GroupService.AzureFunction
{
    public class GetSupportActivitiesConfiguration
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetSupportActivitiesConfiguration> _logger;

        public GetSupportActivitiesConfiguration(IMediator mediator,ILoggerWrapper<GetSupportActivitiesConfiguration> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetSupportActivitiesConfiguration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetSupportActivitiesConfigurationResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetSupportActivitiesConfigurationRequest), "Get support activity configuration")] GetSupportActivitiesConfigurationRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetSupportActivitiesConfigurationResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetSupportActivitiesConfigurationResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetSupportActivitiesConfigurationResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetSupportActivitiesConfiguration", ex);
                return new ObjectResult(ResponseWrapper<GetSupportActivitiesConfigurationResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
