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
    public class GetRegistrationFormVariantHandler : IRequestHandler<GetRegistrationFormVariantRequest, GetRegistrationFormVariantResponse>
    {
        private readonly IRepository _repository;
        public GetRegistrationFormVariantHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetRegistrationFormVariantResponse> Handle(GetRegistrationFormVariantRequest request, CancellationToken cancellationToken)
        {
            return _repository.GetRegistrationFormVariant(request.GroupID.Value,request.Source, cancellationToken);
        }
    }
}
