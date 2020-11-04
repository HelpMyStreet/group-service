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
    public class GetGroupSupportActivityInstructionsHandler : IRequestHandler<GetGroupSupportActivityInstructionsRequest, GetGroupSupportActivityInstructionsResponse>
    {
        private readonly IRepository _repository;
        public GetGroupSupportActivityInstructionsHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupSupportActivityInstructionsResponse> Handle(GetGroupSupportActivityInstructionsRequest request, CancellationToken cancellationToken)
        {
            var instructions =_repository.GetGroupSupportActivityInstructions(request.GroupId, request.SupportActivityType.SupportActivity, cancellationToken);
            return new GetGroupSupportActivityInstructionsResponse()
            {
                Instructions = instructions
            };
        }
    }
}
