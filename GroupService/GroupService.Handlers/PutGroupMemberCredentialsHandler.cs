using GroupService.Core.Exception;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Response;
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
        private readonly ICommunicationService _communicationService;
        public PutGroupMemberCredentialsHandler(IRepository repository, ICommunicationService communicationService)
        {
            _repository = repository;
            _communicationService = communicationService;
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

                if(result)
                {
                    await _communicationService.RequestCommunication(new RequestCommunicationRequest()
                    {
                        RecipientUserID = request.UserId,
                        GroupID = request.GroupId,
                        CommunicationJob = new CommunicationJob() { CommunicationJobType = CommunicationJobTypes.NewCredentials},
                        AdditionalParameters = new Dictionary<string, string>()
                        {
                            { "CredentialId", request.CredentialId.ToString() }
                        }
                    },cancellationToken);
                }
                return result;
            }
            else
            {
                throw new UnauthorisedException();
            }
        }
    }
}
