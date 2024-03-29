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
using AzureFunctions.Extensions.Swashbuckle.Attribute;

namespace GroupService.AzureFunction
{
    public class GetNewRequestActionsSimplified
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetNewRequestActionsSimplified> _logger;

        public GetNewRequestActionsSimplified(IMediator mediator,ILoggerWrapper<GetNewRequestActionsSimplified> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetNewRequestActionsSimplified")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetNewRequestActionsSimplifiedRequest), "get new request actions simplified")] GetNewRequestActionsSimplifiedRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetNewRequestActionsSimplifiedResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetNewRequestActionsSimplified", ex);
                return new ObjectResult(ResponseWrapper<GetNewRequestActionsSimplifiedResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
