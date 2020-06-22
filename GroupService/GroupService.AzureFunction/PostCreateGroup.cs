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

namespace GroupService.AzureFunction
{
    public class PostCreateGroup
    {
        private readonly IMediator _mediator;

        public PostCreateGroup(IMediator mediator)
        {
            _mediator = mediator;
        }

        [FunctionName("PostCreateGroup")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PostCreateGroupResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(PostCreateGroupRequest), "create group")] PostCreateGroupRequest req,
            ILogger log)
        {
            try
            {
                log.LogInformation("C# HTTP trigger function processed a request.");
                PostCreateGroupResponse response = await _mediator.Send(req);
                return new OkObjectResult(ResponseWrapper<PostCreateGroupResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception exc)
            {
                log.LogError("Exception occured in Log Request", exc);
                return new ObjectResult(ResponseWrapper<PostCreateGroupResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
