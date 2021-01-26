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
    public class GetGroupLocationsHandler : IRequestHandler<GetGroupLocationsRequest, GetGroupLocationsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupLocationsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupLocationsResponse> Handle(GetGroupLocationsRequest request, CancellationToken cancellationToken)
        {
            var locations = _repository.GetLocations(request.GroupID.Value, cancellationToken);
            return new GetGroupLocationsResponse()
            {
                Locations = locations
            };
        }
    }
}
