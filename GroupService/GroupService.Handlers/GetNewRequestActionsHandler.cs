using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetNewRequestActionsHandler : IRequestHandler<GetNewRequestActionsRequest, GetNewRequestActionsResponse>
    {
        private readonly IRepository _repository;
        public GetNewRequestActionsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetNewRequestActionsResponse> Handle(GetNewRequestActionsRequest request, CancellationToken cancellationToken)
        {
            if (!request.HelpRequest.ReferringGroupId.HasValue) { throw new System.Exception("No ReferringGroupId"); }

            Dictionary<int, TaskAction> actions = new Dictionary<int, TaskAction>();

            foreach (Job j in request.NewJobsRequest.Jobs)
            {
                TaskAction taskAction = new TaskAction() { TaskActions = new Dictionary<NewTaskAction, List<int>>() };
                
                bool diyRequest = false;

                if (j.Questions != null)
                {
                    var willYoucompleteYourselfQuestion = j.Questions.FirstOrDefault(x => x.Id == (int)Questions.WillYouCompleteYourself);
                    diyRequest = willYoucompleteYourselfQuestion != null && willYoucompleteYourselfQuestion.Answer == "true";
                 }

                bool faceMaskRequest = j.SupportActivity == SupportActivities.FaceMask;

                int targetGroupId;
                if (j.SupportActivity == SupportActivities.FaceMask)
                {
                    targetGroupId = _repository.GetGroupByKey(new GetGroupByKeyRequest() { GroupKey = "ftlos" }, cancellationToken);
                }
                else
                {
                    targetGroupId = request.HelpRequest.ReferringGroupId.Value;
                }
                var groups = _repository.GetGroupAndChildGroups(targetGroupId, cancellationToken);

                taskAction.TaskActions.Add(NewTaskAction.MakeAvailableToGroups, groups);

                if (diyRequest)
                {
                    if (!request.HelpRequest.VolunteerUserId.HasValue) { throw new System.Exception("Cannot create DIY request without VolunteerUserId"); }
                    taskAction.TaskActions.Add(NewTaskAction.AssignToVolunteer, new List<int>() { request.HelpRequest.VolunteerUserId.Value });
                }
                else
                {
                    taskAction.TaskActions.Add(NewTaskAction.NotifyMatchingVolunteers, groups);
                }

                actions.Add(j.JobID, taskAction);
            }

            return new GetNewRequestActionsResponse()
            {
                Actions = actions
            };
        }
    }
}
