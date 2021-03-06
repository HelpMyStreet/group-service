﻿using GroupService.Core.Interfaces.Repositories;
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
    public class GetNewShiftActionsHandler : IRequestHandler<GetNewShiftActionsRequest, GetNewShiftActionsResponse>
    {
        private readonly IRepository _repository;
        public GetNewShiftActionsHandler(IRepository repository)
        {
            _repository = repository;
        }

        private List<int> GetAvailableGroups(GetRequestHelpFormVariantResponse requestJourney, int referringGroupId, string source, CancellationToken cancellationToken)
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

        public async Task<GetNewShiftActionsResponse> Handle(GetNewShiftActionsRequest request, CancellationToken cancellationToken)
        {
            Dictionary<NewTaskAction,List<int>> taskActions = new Dictionary<NewTaskAction, List<int>>();
            
            GetRequestHelpFormVariantResponse requestJourney = _repository.GetRequestHelpFormVariant(request.ReferringGroupId, request.Source ?? "", cancellationToken);

            if (requestJourney == null)
            {
                throw new Exception("null response from GetRequestHelpFormVariant");
            }

            List<int> targetGroups = GetAvailableGroups(requestJourney, request.ReferringGroupId, request.Source, cancellationToken);
            taskActions.Add(NewTaskAction.MakeAvailableToGroups, targetGroups);
            taskActions.Add(NewTaskAction.SendRequestorConfirmation, null);

            if (requestJourney.RequestsRequireApproval)
            {
                taskActions.Add(NewTaskAction.NotifyGroupAdmins, new List<int> { request.ReferringGroupId });
            }
            else
            {
                taskActions.Add(NewTaskAction.SetStatusToOpen, null);
                taskActions.Add(NewTaskAction.NotifyMatchingVolunteers, targetGroups);
            }

            return new GetNewShiftActionsResponse()
            {
                TaskActions = taskActions
            };
        }
    }
}
