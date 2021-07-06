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
    public class GetGroupSupportActivityRadius
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetGroupSupportActivityRadiusRequest> _logger;

        public GetGroupSupportActivityRadius(IMediator mediator,ILoggerWrapper<GetGroupSupportActivityRadiusRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetGroupSupportActivityRadius")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetGroupSupportActivityRadiusResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetGroupSupportActivityRadiusRequest), "get group support activity radius")] GetGroupSupportActivityRadiusRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetGroupSupportActivityRadiusResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetGroupSupportActivityRadiusResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetGroupSupportActivityRadius", ex);
                return new ObjectResult(ResponseWrapper<GetGroupSupportActivityRadiusResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
