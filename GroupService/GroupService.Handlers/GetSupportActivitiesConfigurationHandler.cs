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
    public class GetSupportActivitiesConfigurationHandler : IRequestHandler<GetSupportActivitiesConfigurationRequest, GetSupportActivitiesConfigurationResponse>
    {
        private readonly IRepository _repository;
        public GetSupportActivitiesConfigurationHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetSupportActivitiesConfigurationResponse> Handle(GetSupportActivitiesConfigurationRequest request, CancellationToken cancellationToken)
        {
            List<HelpMyStreet.Utils.Models.SupportActivityConfiguration> config = _repository.GetSupportActivitiesConfiguration(cancellationToken);
            return new GetSupportActivitiesConfigurationResponse()
            {
                SupportActivityConfigurations = config
            };
        }
    }
}
