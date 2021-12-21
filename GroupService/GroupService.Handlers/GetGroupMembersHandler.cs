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
    public class GetGroupMembersHandler : IRequestHandler<GetGroupMembersRequest, GetGroupMembersResponse>
    {
        private readonly IRepository _repository;
        public GetGroupMembersHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMembersResponse> Handle(GetGroupMembersRequest request, CancellationToken cancellationToken)
        {
            List<int> members = _repository.GetGroupMembers(request.GroupID.Value, cancellationToken);
            return new GetGroupMembersResponse()
            {
                Users = members
            };
        }
    }
}
