using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MediatR;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using System.Net;
using AzureFunctions.Extensions.Swashbuckle.Attribute;
using Microsoft.Azure.WebJobs.Extensions.Http;
using HelpMyStreet.Utils.Extensions;
using System.Threading;
using HelpMyStreet.Utils.Utils;
using HelpMyStreet.Contracts.GroupService.Response;

namespace GroupService.AzureFunction
{
    public class GetGroupMembersForGivenRole
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupMembersForGivenRole> _logger;

        public GetGroupMembersForGivenRole(IMediator mediator,ILoggerWrapper<GetGroupMembersForGivenRole> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupMembersForGivenRole")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupMembersForGivenRoleResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupMembersForGivenRoleRequest), "Get Group Members For Given Role")] GetGroupMembersForGivenRoleRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetGroupMembersForGivenRoleResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetGroupMembersForGivenRoleResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetGroupMembersForGivenRoleResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupMembersForGivenRole", ex);
                return new ObjectResult(ResponseWrapper<GetGroupMembersForGivenRoleResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
