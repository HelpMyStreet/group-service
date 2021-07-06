using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetGroupSupportActivityRadiusHandler : IRequestHandler<GetGroupSupportActivityRadiusRequest, GetGroupSupportActivityRadiusResponse>
    {
        private readonly IRepository _repository;
        public GetGroupSupportActivityRadiusHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupSupportActivityRadiusResponse> Handle(GetGroupSupportActivityRadiusRequest request, CancellationToken cancellationToken)
        {
            var radius =_repository.GetGroupSupportActivityRadius(request.GroupId, request.SupportActivityType.SupportActivity, cancellationToken);
            return new GetGroupSupportActivityRadiusResponse()
            {
                SupportRadiusMiles = radius
            };
        }
    }
}
