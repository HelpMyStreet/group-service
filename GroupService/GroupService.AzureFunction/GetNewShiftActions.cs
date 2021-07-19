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
    public class GetNewShiftActions
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetNewShiftActions> _logger;

        public GetNewShiftActions(IMediator mediator,ILoggerWrapper<GetNewShiftActions> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetNewShiftActions")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetNewShiftActionsRequest), "get new shift actions")] GetNewShiftActionsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetNewShiftActionsResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetNewShiftActionsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetNewShiftActionsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetNewShiftActionsResponse", ex);
                return new ObjectResult(ResponseWrapper<GetNewRequestActionsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
