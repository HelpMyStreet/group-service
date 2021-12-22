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
        private readonly ITargetGroupService _targetGroupService;
        public GetEligibleVolunteersForRequestHandler(IRepository repository, IUserService userService, ITargetGroupService targetGroupService)
        {
            _repository = repository;
            _userService = userService;
            _targetGroupService = targetGroupService;
        }

        public async Task<GetEligibleVolunteersForRequestResponse> Handle(GetEligibleVolunteersForRequestRequest request, CancellationToken cancellationToken)
        {
            var groupVolunteers = await _targetGroupService.GetTargetGroupsMembers(request.ReferringGroupId, request.Source, cancellationToken);

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
