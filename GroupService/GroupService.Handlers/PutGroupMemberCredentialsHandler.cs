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
    public class PutGroupMemberCredentialsHandler : IRequestHandler<PutGroupMemberCredentialsRequest, bool>
    {
        private readonly IRepository _repository;
        public PutGroupMemberCredentialsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(PutGroupMemberCredentialsRequest request, CancellationToken cancellationToken)
        {
            bool hasPermission = false;

            var credentialVerifiedBy = _repository.GetCredentialVerifiedBy(request.GroupId, request.CredentialId);

            if (credentialVerifiedBy == HelpMyStreet.Utils.Enums.CredentialVerifiedBy.GroupAdmin)
            {
                hasPermission = request.AuthorisedByUserID != request.UserId 
                    && _repository.UserIsInRoleForGroup(
                            request.AuthorisedByUserID,
                            request.GroupId,
                            HelpMyStreet.Utils.Enums.GroupRoles.UserAdmin);
            }

            if (hasPermission)
            {
                var result = _repository.AddGroupMemberCredentials(request);
                return result;
            }
            else
            {
                throw new UnauthorisedException();
            }
        }
    }
}
