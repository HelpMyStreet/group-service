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
    public class PostAddUserToDefaultGroups
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<PostAddUserToDefaultGroups> _logger;

        public PostAddUserToDefaultGroups(IMediator mediator,ILoggerWrapper<PostAddUserToDefaultGroups> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("PostAddUserToDefaultGroups")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PostAddUserToDefaultGroupsResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(PostAddUserToDefaultGroupsRequest), "post add user to default groups")] PostAddUserToDefaultGroupsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    PostAddUserToDefaultGroupsResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<PostAddUserToDefaultGroupsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<PostAddUserToDefaultGroupsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in PostAddUserToDefaultGroups", ex);
                return new ObjectResult(ResponseWrapper<PostAddUserToDefaultGroupsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
