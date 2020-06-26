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
    public class PostCreateGroup
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<PostCreateGroupRequest> _logger;

        public PostCreateGroup(IMediator mediator,ILoggerWrapper<PostCreateGroupRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("PostCreateGroup")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PostCreateGroupResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(PostCreateGroupRequest), "create group")] PostCreateGroupRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    PostCreateGroupResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<PostCreateGroupResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<PostCreateGroupResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in PostCreateGroup", ex);
                return new ObjectResult(ResponseWrapper<PostCreateGroupResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
