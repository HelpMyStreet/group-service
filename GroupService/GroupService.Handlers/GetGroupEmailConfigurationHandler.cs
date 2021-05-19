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
            return new GetGroupEmailConfigurationResponse()
            {
                EmailConfigurations = _repository.GetGroupEmailConfiguration(request.GroupId, request.GroupEmailVariantType.GroupEmailVariant, cancellationToken)
            };
        }
    }
}
