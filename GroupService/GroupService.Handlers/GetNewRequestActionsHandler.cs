using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using MediatR;
using System;
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
            Dictionary<int, TaskAction> actions = new Dictionary<int, TaskAction>();

            foreach (Job j in request.NewJobsRequest.Jobs)
            {
                TaskAction taskAction = new TaskAction() { TaskActions = new Dictionary<NewTaskAction, List<int>>() };
                
                bool faceMaskRequest = j.SupportActivity == SupportActivities.FaceMask;

                GetRequestHelpFormVariantResponse requestJourney = _repository.GetRequestHelpFormVariant(request.HelpRequest.ReferringGroupId, request.HelpRequest.Source ?? "", cancellationToken);

                if (requestJourney == null)
                {
                    throw new Exception("null response from GetRequestHelpFormVariant");
                }

                int targetGroupId;
                bool includeChildGroups;

                switch (requestJourney.TargetGroups)
                {
                    case TargetGroups.GenericGroup: 
                        targetGroupId = -1;
                        includeChildGroups = false;
                        break;
                    case TargetGroups.ParentGroup: 
                        targetGroupId = _repository.GetGroupById(request.HelpRequest.ReferringGroupId, cancellationToken).ParentGroupId.Value;
                        includeChildGroups = false;
                        break;
                    case TargetGroups.SiblingsAndParentGroup:
                        targetGroupId = _repository.GetGroupById(request.HelpRequest.ReferringGroupId, cancellationToken).ParentGroupId.Value;
                        includeChildGroups = true;
                        break;
                    case TargetGroups.ThisGroup:
                        targetGroupId = request.HelpRequest.ReferringGroupId;
                        includeChildGroups = false;
                        break;
                    case TargetGroups.ThisGroupAndChildren:
                        targetGroupId = request.HelpRequest.ReferringGroupId;
                        includeChildGroups = true;
                        break;
                    default:
                        throw new Exception($"Unexpected TargetGroups value {requestJourney.TargetGroups}");
                }
                
                List<int> targetGroups;

                if (includeChildGroups)
                {
                    targetGroups = _repository.GetGroupAndChildGroups(targetGroupId, cancellationToken);
                }
                else
                {
                    targetGroups = new List<int>() { targetGroupId };
                }

                taskAction.TaskActions.Add(NewTaskAction.MakeAvailableToGroups, targetGroups);

                if (requestJourney.RequestsRequireApproval)
                {
                    taskAction.TaskActions.Add(NewTaskAction.NotifyGroupAdmins, new List<int> { request.HelpRequest.ReferringGroupId });
                } 
                else
                {
                    taskAction.TaskActions.Add(NewTaskAction.SetStatusToOpen, null);
                    taskAction.TaskActions.Add(NewTaskAction.NotifyMatchingVolunteers, targetGroups);
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
