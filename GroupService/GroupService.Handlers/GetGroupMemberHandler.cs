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
    public class GetGroupMemberHandler : IRequestHandler<GetGroupMemberRequest, GetGroupMemberResponse>
    {
        private readonly IRepository _repository;
        public GetGroupMemberHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMemberResponse> Handle(GetGroupMemberRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetGroupMember(request.GroupId, request.UserId);

            return new GetGroupMemberResponse()
            {
                UserInGroup = result
            };
        }
    }
}
