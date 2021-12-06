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
using HelpMyStreet.Contracts;
using Microsoft.Extensions.Logging;

namespace GroupService.AzureFunction
{
    public class GetNewsTicker
    {
        private readonly IMediator _mediator;

        public GetNewsTicker(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [FunctionName("GetNewsTicker")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(NewsTickerResponse))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            [RequestBodyType(typeof(NewsTickerRequest), "Get News Ticker Request")] NewsTickerRequest req,
            ILogger log)
        {
            try
            {
                NewsTickerResponse response = await _mediator.Send(req);

                return new OkObjectResult(ResponseWrapper<NewsTickerResponse, GroupServiceErrorCode>.CreateSuccessfulResponse(response));
            }
            catch (Exception exc)
            {
                return new ObjectResult(ResponseWrapper<NewsTickerResponse, GroupServiceErrorCode>.CreateUnsuccessfulResponse(GroupServiceErrorCode.InternalServerError, "Internal Error")) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
