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

    public class GetGroupMemberDetails
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupMemberDetailsRequest> _logger;

        public GetGroupMemberDetails(IMediator mediator,ILoggerWrapper<GetGroupMemberDetailsRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupMemberDetails")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupMemberDetailsResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupMemberDetailsRequest), "Get Group Member Details")] GetGroupMemberDetailsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupMemberDetailsResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (UnauthorisedException ex)
            {
                return new ObjectResult(ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.UnauthorisedError, "Unauthorised Error")) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupMemberDetails", ex);
                return new ObjectResult(ResponseWrapper<GetGroupMemberDetailsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
