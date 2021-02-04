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
            List<List<int>> credentials;

            credentials = _repository.GetGroupActivityCredentialSets(
                request.GroupId, 
                request.SupportActivityType.SupportActivity);

            if(credentials == null)
            {
                throw new Exception($"Unexpected null value returned for GroupID={request.GroupId} and supportActivity={request.SupportActivityType.SupportActivity.ToString()}");

            }

            return new GetGroupActivityCredentialsResponse()
            {
                CredentialSets = credentials
            };
        }
    }
}
