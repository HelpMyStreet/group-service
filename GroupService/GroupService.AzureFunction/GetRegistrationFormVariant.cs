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

namespace GroupService.AzureFunction
{
    public class GetRegistrationFormVariant
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetRegistrationFormVariantRequest> _logger;

        public GetRegistrationFormVariant(IMediator mediator,ILoggerWrapper<GetRegistrationFormVariantRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetRegistrationFormVariant")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            GetRegistrationFormVariantRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetRegistrationFormVariantResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetRegistrationFormVariant", ex);
                return new ObjectResult(ResponseWrapper<GetRegistrationFormVariantResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
