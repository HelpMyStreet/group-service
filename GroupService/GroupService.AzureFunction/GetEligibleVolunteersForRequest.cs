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

    public class GetEligibleVolunteersForRequest
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetEligibleVolunteersForRequest> _logger;

        public GetEligibleVolunteersForRequest(IMediator mediator,ILoggerWrapper<GetEligibleVolunteersForRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetEligibleVolunteersForRequest")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetEligibleVolunteersForRequestResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetEligibleVolunteersForRequestRequest), "Get eligible volunteers For request")] GetEligibleVolunteersForRequestRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetEligibleVolunteersForRequestResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetEligibleVolunteersForRequestResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetEligibleVolunteersForRequest", ex);
                return new ObjectResult(ResponseWrapper<GetEligibleVolunteersForRequestResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
