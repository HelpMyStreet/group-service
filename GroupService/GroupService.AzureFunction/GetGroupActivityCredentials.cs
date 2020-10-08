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

    public class GetGroupActivityCredentials
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupActivityCredentialsRequest> _logger;

        public GetGroupActivityCredentials(IMediator mediator,ILoggerWrapper<GetGroupActivityCredentialsRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupActivityCredentials")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupActivityCredentialsResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupActivityCredentialsRequest), "Get Group Activity Credentials")] GetGroupActivityCredentialsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupActivityCredentialsResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupActivityCredentials", ex);
                return new ObjectResult(ResponseWrapper<GetGroupActivityCredentialsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
