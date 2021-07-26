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
using GroupService.Core.Exception;

namespace GroupService.AzureFunction
{
    public class GetAllGroupSupportActivityRadii
    {
        private readonly IMediator _mediator;
        private readonly ILoggerWrapper<GetAllGroupSupportActivityRadii> _logger;

        public GetAllGroupSupportActivityRadii(IMediator mediator,ILoggerWrapper<GetAllGroupSupportActivityRadii> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [FunctionName("GetAllGroupSupportActivityRadii")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetAllGroupSupportActivityRadiiResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(GetAllGroupSupportActivityRadiiRequest), "get all group support activity radii")] GetAllGroupSupportActivityRadiiRequest req,
            CancellationToken cancellationToken)
        {
            try
            {
                GetAllGroupSupportActivityRadiiResponse response = await _mediator.Send(req, cancellationToken);
                return new OkObjectResult(ResponseWrapper<GetAllGroupSupportActivityRadiiResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (BadRequestException ex)
            {
                return new ObjectResult(ResponseWrapper<GetAllGroupSupportActivityRadiiResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.BadRequestError, "Bad Request Error")) { StatusCode = StatusCodes.Status400BadRequest };
            }
            catch (Exception ex)
            {
                _logger.LogErrorAndNotifyNewRelic($"Unhandled error in GetAllGroupSupportActivityRadii", ex);
                return new ObjectResult(ResponseWrapper<GetAllGroupSupportActivityRadiiResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
