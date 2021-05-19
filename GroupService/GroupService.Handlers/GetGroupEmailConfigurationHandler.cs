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
    public class GetGroupEmailConfigurationHandler : IRequestHandler<GetGroupEmailConfigurationRequest, GetGroupEmailConfigurationResponse>
    {
        private readonly IRepository _repository;
        public GetGroupEmailConfigurationHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetGroupEmailConfigurationResponse> Handle(GetGroupEmailConfigurationRequest request, CancellationToken cancellationToken)
        {
            //var instructions =_repository.GetGroupSupportActivityInstructions(request.GroupId, request.SupportActivityType.SupportActivity, cancellationToken);
            return new GetGroupEmailConfigurationResponse()
            {
                EmailConfigurations = new List<KeyValuePair<string, string>>()
            };
        }
    }
}
