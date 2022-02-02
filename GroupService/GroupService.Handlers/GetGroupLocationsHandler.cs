using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> groups = new List<int>();
            groups.Add(request.GroupID.Value);

            if (request.IncludeChildGroups)
            {
                var childGroups = _repository.GetChildGroups(request.GroupID.Value, cancellationToken);

                if (childGroups.Count > 0)
                {
                    groups.AddRange(childGroups.Select(x => x.GroupId).ToList());
                }

            }

            var locations = _repository.GetGroupLocations(groups, cancellationToken);
            return new GetGroupLocationsResponse()
            {
                Locations = locations.Select(x=> x.Location).Distinct().ToList()
            };
        }
    }
}
