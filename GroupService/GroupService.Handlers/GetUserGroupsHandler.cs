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
    public class GetUserGroupsHandler : IRequestHandler<GetUserGroupsRequest, GetUserGroupsResponse>
    {
        private readonly IRepository _repository;
        public GetUserGroupsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetUserGroupsResponse> Handle(GetUserGroupsRequest request, CancellationToken cancellationToken)
        {
            List<int> groups = _repository.GetUserGroups(request, cancellationToken);
            return new GetUserGroupsResponse()
            {
                Groups = groups
            };
        }
    }
}
