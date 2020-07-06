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
    public class GetChildGroupsHandler : IRequestHandler<GetChildGroupsRequest, GetChildGroupsResponse>
    {
        private readonly IRepository _repository;
        public GetChildGroupsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetChildGroupsResponse> Handle(GetChildGroupsRequest request, CancellationToken cancellationToken)
        {
            var childGroups =_repository.GetChildGroups(request.GroupID.Value, cancellationToken);
            return new GetChildGroupsResponse()
            {
                ChildGroups = childGroups
            };
        }
    }
}
