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
    public class PutGroupMemberCredentialsHandler : IRequestHandler<PutGroupMemberCredentialsRequest, bool>
    {
        private readonly IRepository _repository;
        public PutGroupMemberCredentialsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(PutGroupMemberCredentialsRequest request, CancellationToken cancellationToken)
        {
            var result = _repository.AddGroupMemberCredentials(request);
            return result;
        }
    }
}
