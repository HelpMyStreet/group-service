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
    public class GetGroupByKeyHandler : IRequestHandler<GetGroupByKeyRequest, GetGroupByKeyResponse>
    {
        private readonly IRepository _repository;
        public GetGroupByKeyHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupByKeyResponse> Handle(GetGroupByKeyRequest request, CancellationToken cancellationToken)
        {
            int groupId =_repository.GetGroupByKey(request, cancellationToken);
            return new GetGroupByKeyResponse()
            {
                GroupId = groupId
            };
        }
    }
}
