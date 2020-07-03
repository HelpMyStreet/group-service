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
    public class GetGroupHandler : IRequestHandler<GetGroupRequest, GetGroupResponse>
    {
        private readonly IRepository _repository;
        public GetGroupHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupResponse> Handle(GetGroupRequest request, CancellationToken cancellationToken)
        {
            var group =_repository.GetGroupById(request.GroupID.Value, cancellationToken);
            return new GetGroupResponse()
            {
                Group = group
            };
        }
    }
}
