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
    public class GetGroupsWithMapDetailsHandler : IRequestHandler<GetGroupsWithMapDetailsRequest, GetGroupsWithMapDetailsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupsWithMapDetailsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupsWithMapDetailsResponse> Handle(GetGroupsWithMapDetailsRequest request, CancellationToken cancellationToken)
        {
            var groups =_repository.GetGroupsWithMapDetails(request.MapLocation.MapLocation, cancellationToken);
            return new GetGroupsWithMapDetailsResponse()
            {
                Groups = groups
            };
        }
    }
}
