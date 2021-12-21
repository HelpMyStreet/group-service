using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetEligibleVolunteersForRequestHandler : IRequestHandler<GetEligibleVolunteersForRequestRequest, GetEligibleVolunteersForRequestResponse>
    {
        private readonly IRepository _repository;
        private readonly IUserService _userService;
        public GetEligibleVolunteersForRequestHandler(IRepository repository, IUserService userService)
        {
            _repository = repository;
            _userService = userService;
        }

        private List<int> GetTargetGroups(int referringGroupId, string source, CancellationToken cancellationToken)
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
                    throw new Exception($"Unexpected TargetGroups value {requestJourney.TargetGroups}");
            }

            List<int> targetGroups;

            if (includeChildGroups)
            {
                targetGroups = _repository.GetGroupAndChildGroups(targetGroupId, cancellationToken);

                if (targetGroups == null)
                {
                    throw new Exception("Null response from GetGroupAndChildGroups");
                }
            }
            else
            {
                targetGroups = new List<int>() { targetGroupId };
            }

            return targetGroups;
        }

        public async Task<GetEligibleVolunteersForRequestResponse> Handle(GetEligibleVolunteersForRequestRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<int> groupVolunteers = new List<int>();
            var targetGroups = GetTargetGroups(request.ReferringGroupId, string.Empty, cancellationToken);

            targetGroups.ForEach(group =>
            {
                var members = _repository.GetGroupMembers(group, cancellationToken);
                groupVolunteers = groupVolunteers.Concat(members);            
            });

            groupVolunteers = groupVolunteers.Distinct().ToList();

            var strategy = _repository.GetGroupNewRequestNotificationStrategy(request.ReferringGroupId, cancellationToken);

            var volunteerSummaries = await _userService.GetVolunteersByPostcodeAndActivity(
                request.PostCode,
                new List<SupportActivities>()
                {
                    request.SupportActivityType.SupportActivity
                },
                null,
                cancellationToken);

            volunteerSummaries = volunteerSummaries
                .Where(v => groupVolunteers.Contains(v.UserID))
                .OrderBy(v => v.DistanceInMiles)
                .Take(strategy.MaxVolunteer);

            return new GetEligibleVolunteersForRequestResponse()
            {
                VolunteerSummaries = volunteerSummaries
            };
        }
    }
}
