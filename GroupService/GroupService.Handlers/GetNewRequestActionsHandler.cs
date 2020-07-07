using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using MediatR;
using System.Collections.Generic;
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
            Dictionary<int, TaskAction> actions = new Dictionary<int, TaskAction>();


            if (request.HelpRequest.Source == "DIY" && request.HelpRequest.VolunteerUserId.HasValue)
            {
                TaskAction taskAction = new TaskAction();
                taskAction.TaskActions = new Dictionary<NewTaskAction, List<int>>();
                taskAction.TaskActions.Add(NewTaskAction.AssignToVolunteer, new List<int>() { request.HelpRequest.VolunteerUserId.Value });

                foreach (Job j in request.NewJobsRequest.Jobs)
                {
                    actions.Add(j.JobID, taskAction);
                }
            }
            else if (request.HelpRequest.ReferringGroupId.HasValue)
            {
                foreach (Job j in request.NewJobsRequest.Jobs)
                {
                    TaskAction taskAction = new TaskAction();
                    taskAction.TaskActions = new Dictionary<NewTaskAction, List<int>>();
                    int targetGroupId = request.HelpRequest.ReferringGroupId.Value;
                    if (j.SupportActivity == SupportActivities.FaceMask)
                    {
                        targetGroupId = _repository.GetGroupByKey(new GetGroupByKeyRequest() { GroupKey = "ftlos" }, cancellationToken);
                    }

                    var groups = _repository.GetGroupAndChildGroups(targetGroupId, cancellationToken);
                    if (groups != null)
                    {
                        taskAction.TaskActions.Add(NewTaskAction.MakeAvailableToGroups, groups);
                        taskAction.TaskActions.Add(NewTaskAction.NotifyMatchingVolunteers, groups);

                        actions.Add(j.JobID, taskAction);
                    }
                }
            }

            return new GetNewRequestActionsResponse()
            {
                Actions = actions
            };
        }
    }
}
