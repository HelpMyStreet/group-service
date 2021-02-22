using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Extensions;
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

        private List<int> GetTargetGroups(GetRequestHelpFormVariantResponse requestJourney, int referringGroupId, string source, CancellationToken cancellationToken)
        {
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

        public async Task<GetNewRequestActionsResponse> Handle(GetNewRequestActionsRequest request, CancellationToken cancellationToken)
        {
            Dictionary<Guid, TaskAction> actions = new Dictionary<Guid, TaskAction>();
            Dictionary<NewTaskAction, List<int>> requestTaskActions = new Dictionary<NewTaskAction, List<int>>();

            GetRequestHelpFormVariantResponse requestJourney = _repository.GetRequestHelpFormVariant(request.HelpRequest.ReferringGroupId, request.HelpRequest.Source ?? "", cancellationToken);

            if (requestJourney == null)
            {
                throw new Exception("null response from GetRequestHelpFormVariant");
            }

            List<int> targetGroups = GetTargetGroups(requestJourney, request.HelpRequest.ReferringGroupId, request.HelpRequest.Source, cancellationToken);

            if (requestJourney.RequestsRequireApproval)
            {
                requestTaskActions.Add(NewTaskAction.NotifyGroupAdmins, new List<int> { request.HelpRequest.ReferringGroupId });
            }
            else
            {
                requestTaskActions.Add(NewTaskAction.SetStatusToOpen, null);
            }
            requestTaskActions.Add(NewTaskAction.SendRequestorConfirmation, null);
            requestTaskActions.Add(NewTaskAction.MakeAvailableToGroups, targetGroups);

            RequestType requestType = request.NewJobsRequest.Jobs.First().SupportActivity.RequestType();

            if (!requestJourney.RequestsRequireApproval && requestType == RequestType.Task)
            {
                requestTaskActions.Add(NewTaskAction.NotifyMatchingVolunteers, targetGroups);
            }

            return new GetNewRequestActionsResponse()
            {
                Actions = actions,
                RequestTaskActions = requestTaskActions
            };
        }
    }
}
