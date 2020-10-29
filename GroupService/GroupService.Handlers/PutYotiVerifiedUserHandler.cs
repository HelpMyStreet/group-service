using GroupService.Core.Exception;
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
    public class PutYotiVerifiedUserHandler : IRequestHandler<PutYotiVerifiedUserRequest, bool>
    {
        private readonly IRepository _repository;
        public PutYotiVerifiedUserHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(PutYotiVerifiedUserRequest request, CancellationToken cancellationToken)
        {
            return _repository.AddYotiVerifiedUsers(request);
        }
    }
}
