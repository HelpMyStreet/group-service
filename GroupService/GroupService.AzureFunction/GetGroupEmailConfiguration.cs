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
    public class GetGroupEmailConfiguration
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupEmailConfiguration> _logger;

        public GetGroupEmailConfiguration(IMediator mediator,ILoggerWrapper<GetGroupEmailConfiguration> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupEmailConfiguration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupEmailConfigurationResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetGroupEmailConfigurationRequest), "get group email configuration")] GetGroupEmailConfigurationRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupEmailConfigurationResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupEmailConfigurationResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupEmailConfiguration", ex);
                return new ObjectResult(ResponseWrapper<GetGroupEmailConfigurationResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
