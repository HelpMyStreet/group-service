using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class TargetGroupService : ITargetGroupService
    {
        private readonly IRepository _repository;

        public TargetGroupService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<int>> GetTargetGroups(int referringGroupId, string source, CancellationToken cancellationToken)
        {
            GetRequestHelpFormVariantResponse requestJourney = _repository.GetRequestHelpFormVariant(referringGroupId, source ?? "", cancellationToken);

            int targetGroupId;
            bool includeChildGroups;

            switch (requestJourney.TargetGroups)
            {
                case TargetGroups.GenericGroup:
                    targetGroupId = -1;
                    includeChildGroups = false;
                    break;
                case TargetGroups.ParentGroup:
                    targetGroupId = _repository.GetGroupById(referringGroupId, cancellationToken).ParentGroupId.Value;
                    includeChildGroups = false;
                    break;
                case TargetGroups.SiblingsAndParentGroup:
                    targetGroupId = _repository.GetGroupById(referringGroupId, cancellationToken).ParentGroupId.Value;
                    includeChildGroups = true;
                    break;
                case TargetGroups.ThisGroup:
                    targetGroupId = referringGroupId;
                    includeChildGroups = false;
                    break;
                case TargetGroups.ThisGroupAndChildren:
                    targetGroupId = referringGroupId;
                    includeChildGroups = true;
                    break;
                default:
                    throw new System.Exception($"Unexpected TargetGroups value {requestJourney.TargetGroups}");
            }

            List<int> targetGroups;

            if (includeChildGroups)
            {
                targetGroups = _repository.GetGroupAndChildGroups(targetGroupId, cancellationToken);

                if (targetGroups == null)
                {
                    throw new System.Exception("Null response from GetGroupAndChildGroups");
                }
            }
            else
            {
                targetGroups = new List<int>() { targetGroupId };
            }

            return targetGroups;
        }

        public async Task<IEnumerable<int>> GetTargetGroupsMembers(int referringGroupId, string source, CancellationToken cancellationToken)
        {
            var targetGroups = await GetTargetGroups(referringGroupId, source, cancellationToken);
            var groupVolunteers = targetGroups.SelectMany(group => _repository.GetGroupMembers(group, cancellationToken));
            return groupVolunteers.Distinct().ToList();
        }
    }
}
