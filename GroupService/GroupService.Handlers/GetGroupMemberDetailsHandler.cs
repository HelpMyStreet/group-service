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
    public class GetGroupMemberDetailsHandler : IRequestHandler<GetGroupMemberDetailsRequest, GetGroupMemberDetailsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupMemberDetailsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupMemberDetailsResponse> Handle(GetGroupMemberDetailsRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetGroupMemberDetails(request);
            return result;
        }
    }
}
