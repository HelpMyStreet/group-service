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
    public class GetGroupCredentialsHandler : IRequestHandler<GetGroupCredentialsRequest, GetGroupCredentialsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupCredentialsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupCredentialsResponse> Handle(GetGroupCredentialsRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetGroupCredentials(request.GroupID);
            return new GetGroupCredentialsResponse()
            {
                GroupCredentials = result
            };
        }
    }
}
