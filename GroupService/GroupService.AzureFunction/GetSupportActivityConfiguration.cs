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
    public class GetSupportActivityConfiguration
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetSupportActivityConfigurationRequest> _logger;

        public GetSupportActivityConfiguration(IMediator mediator,ILoggerWrapper<GetSupportActivityConfigurationRequest> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetSupportActivityConfiguration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetSupportActivityConfigurationResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            [RequestBodyType(typeof(GetSupportActivityConfigurationRequest), "Get support activity configuration")] GetSupportActivityConfigurationRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                if (req.IsValid(out var validationResults))
                {
                    GetSupportActivityConfigurationResponse response = await _mediator.Send(req, cancellationToken);
                    return new OkObjectResult(ResponseWrapper<GetSupportActivityConfigurationResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
                }
                else
                {
                    return new ObjectResult(ResponseWrapper<GetSupportActivityConfigurationResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.ValidationError, validationResults)) { StatusCode = 422 };
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetSupportActivityConfiguration", ex);
                return new ObjectResult(ResponseWrapper<GetSupportActivityConfigurationResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
