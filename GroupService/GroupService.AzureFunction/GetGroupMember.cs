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

    public class GetGroupMember
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupMemberRequest> _logger;

        public GetGroupMember(IMediator mediator,ILoggerWrapper<GetGroupMemberRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupMember")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupMemberResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupMemberRequest), "Get Group Member")] GetGroupMemberRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupMemberResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupMemberResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (UnauthorisedException ex)
            {
                return new ObjectResult(ResponseWrapper<GetGroupMembersResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.UnauthorisedError, "Unauthorised Error")) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupMember", ex);
                return new ObjectResult(ResponseWrapper<GetGroupMemberResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
