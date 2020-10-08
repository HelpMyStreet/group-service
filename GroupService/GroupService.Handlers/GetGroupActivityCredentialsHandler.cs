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
    public class GetGroupActivityCredentialsHandler : IRequestHandler<GetGroupActivityCredentialsRequest, GetGroupActivityCredentialsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupActivityCredentialsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupActivityCredentialsResponse> Handle(GetGroupActivityCredentialsRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.GetGroupActivityCredentialSets(
                request.GroupId, 
                request.SupportActivityType.SupportActivity);
            return new GetGroupActivityCredentialsResponse()
            {
                CredentialSets = result
            };
        }
    }
}
