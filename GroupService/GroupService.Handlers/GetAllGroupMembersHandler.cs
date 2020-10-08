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
    public class GetAllGroupMembersHandler : IRequestHandler<GetAllGroupMembersRequest, GetAllGroupMembersResponse>
    {
        private readonly IRepository _repository;
        public GetAllGroupMembersHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllGroupMembersResponse> Handle(GetAllGroupMembersRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAllGroupMembers(request.GroupId);

            return new GetAllGroupMembersResponse()
            {
                UserInGroups = result
            };
        }
    }
}
