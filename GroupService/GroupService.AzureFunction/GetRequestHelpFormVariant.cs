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
    public class GetRequestHelpFormVariant
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetRequestHelpFormVariant> _logger;

        public GetRequestHelpFormVariant(IMediator mediator,ILoggerWrapper<GetRequestHelpFormVariant> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetRequestHelpFormVariant")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetRequestHelpFormVariantResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetRequestHelpFormVariantRequest), "get request help form variant")] GetRequestHelpFormVariantRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetRequestHelpFormVariantResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetRequestHelpFormVariantResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetRequestHelpFormVariantResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetRequestHelpFormVariant", ex);
                return new ObjectResult(ResponseWrapper<GetRequestHelpFormVariantResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
