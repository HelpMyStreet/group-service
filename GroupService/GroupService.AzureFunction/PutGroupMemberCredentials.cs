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
using GroupService.Core.Exception;

namespace GroupService.AzureFunction
{

    public class PutGroupMemberCredentials
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<PutGroupMemberCredentialsRequest> _logger;

        public PutGroupMemberCredentials(IMediator mediator,ILoggerWrapper<PutGroupMemberCredentialsRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("PutGroupMemberCredentials")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "put", Route = null)]
            [RequestBodyType(typeof(PutGroupMemberCredentialsRequest), "Put Group Member Credentials")] PutGroupMemberCredentialsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                bool response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<bool, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (UnauthorisedException ex)
            {
                return new ObjectResult(ResponseWrapper<bool, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.UnauthorisedError, "Unauthorised Error")) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in PutGroupMemberCredentials", ex);
                return new ObjectResult(ResponseWrapper<bool, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
