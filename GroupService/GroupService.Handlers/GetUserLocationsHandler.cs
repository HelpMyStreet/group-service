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
    public class GetUserLocationsHandler : IRequestHandler<GetUserLocationsRequest, GetUserLocationsResponse>
    {
        private readonly IRepository _repository;
        public GetUserLocationsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetUserLocationsResponse> Handle(GetUserLocationsRequest request, CancellationToken cancellationToken)
        {
            List<int> groups = _repository.GetUserGroups(request.UserID.Value, cancellationToken);
            return new GetUserLocationsResponse()
            {
                Locations = _repository.GetLocations(groups, cancellationToken)
            };
        }
    }
}
