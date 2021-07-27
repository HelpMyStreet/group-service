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
    public class GetGroupNewRequestNotificationStrategy
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupNewRequestNotificationStrategy> _logger;

        public GetGroupNewRequestNotificationStrategy(IMediator mediator,ILoggerWrapper<GetGroupNewRequestNotificationStrategy> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupNewRequestNotificationStrategy")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupNewRequestNotificationStrategyResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetGroupNewRequestNotificationStrategyRequest), "get group")] GetGroupNewRequestNotificationStrategyRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetGroupNewRequestNotificationStrategyResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupNewRequestNotificationStrategy", ex);
                return new ObjectResult(ResponseWrapper<GetGroupNewRequestNotificationStrategyResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
