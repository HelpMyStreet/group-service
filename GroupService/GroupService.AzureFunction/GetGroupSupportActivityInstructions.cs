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
    public class GetGroupSupportActivityInstructions
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupSupportActivityInstructionsRequest> _logger;

        public GetGroupSupportActivityInstructions(IMediator mediator,ILoggerWrapper<GetGroupSupportActivityInstructionsRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupSupportActivityInstructions")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupSupportActivityInstructionsResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetGroupSupportActivityInstructionsRequest), "get group support activity instructions")] GetGroupSupportActivityInstructionsRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupSupportActivityInstructionsResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupSupportActivityInstructions", ex);
                return new ObjectResult(ResponseWrapper<GetGroupSupportActivityInstructionsResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
