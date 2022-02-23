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
    public class GetUserRolesHandler : IRequestHandler<GetUserRolesRequest, GetUserRolesResponse>
    {
        private readonly IRepository _repository;
        public GetUserRolesHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetUserRolesResponse> Handle(GetUserRolesRequest request, CancellationToken cancellationToken)
        {
            var roles = _repository.GetUserRoles(request.UserID.Value, cancellationToken);
            return new GetUserRolesResponse()
            {
                UserGroupRoles = roles
            };
        }
    }
}
