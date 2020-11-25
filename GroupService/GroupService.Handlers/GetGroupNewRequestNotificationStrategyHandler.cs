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
    public class GetGroupNewRequestNotificationStrategyHandler : IRequestHandler<GetGroupNewRequestNotificationStrategyRequest, GetGroupNewRequestNotificationStrategyResponse>
    {
        private readonly IRepository _repository;
        public GetGroupNewRequestNotificationStrategyHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupNewRequestNotificationStrategyResponse> Handle(GetGroupNewRequestNotificationStrategyRequest request, CancellationToken cancellationToken)
        {
            return _repository.GetGroupNewRequestNotificationStrategy(request.GroupID.Value, cancellationToken);
        }
    }
}
