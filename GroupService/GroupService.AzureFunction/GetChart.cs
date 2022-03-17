using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.AspNetCore.Http;
using MediatR;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Contracts.RequestService.Response;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Net;
using AzureFunctions.Extensions.Swashbuckle.Attribute;
using HelpMyStreet.Contracts.ReportService.Response;
using HelpMyStreet.Contracts.ReportService.Request;
using Microsoft.Extensions.Logging;

namespace GroupService.AzureFunction
{
    public class GetChart
    {
        private readonly IMediator _mediator;

        public GetChart(IMediator mediator)
        {
            _mediator = mediator;
        }

        [FunctionName("GetChart")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetChartResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            [RequestBodyType(typeof(GetChartRequest), "Get chart request")] GetChartRequest req,
            ILogger log)
        {
            try
            {
                GetChartResponse response = await _mediator.Send(req);

                return new OkObjectResult(ResponseWrapper<GetChartResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception exc)
            {
                return new ObjectResult(ResponseWrapper<GetChartResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
