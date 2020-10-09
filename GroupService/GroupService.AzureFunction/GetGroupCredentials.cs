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

    public class GetGroupCredentials
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupCredentialsRequest> _logger;

        public GetGroupCredentials(IMediator mediator,ILoggerWrapper<GetGroupCredentialsRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupCredentials")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupCredentialsResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupCredentialsRequest), "Get Group Credentials")] GetGroupCredentialsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupCredentialsResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupCredentialsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupCredentials", ex);
                return new ObjectResult(ResponseWrapper<GetGroupCredentialsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
