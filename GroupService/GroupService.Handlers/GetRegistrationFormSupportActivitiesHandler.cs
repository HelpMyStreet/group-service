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
    public class GetRegistrationFormSupportActivitiesHandler : IRequestHandler<GetRegistrationFormSupportActivitiesRequest, GetRegistrationFormSupportActivitiesResponse>
    {
        private readonly IRepository _repository;
        public GetRegistrationFormSupportActivitiesHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetRegistrationFormSupportActivitiesResponse> Handle(GetRegistrationFormSupportActivitiesRequest request, CancellationToken cancellationToken)
        {
            var supportActivityDetails = _repository.GetSupportActivityDetails(request.RegistrationFormVariantRequest.RegistrationFormVariant, cancellationToken);
            return new GetRegistrationFormSupportActivitiesResponse()
            {
                SupportActivityDetails = supportActivityDetails
            };
        }
    }
}
