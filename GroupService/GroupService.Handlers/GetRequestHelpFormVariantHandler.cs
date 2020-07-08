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
    public class GetRequestHelpFormVariantHandler : IRequestHandler<GetRequestHelpFormVariantRequest, GetRequestHelpFormVariantResponse>
    {
        private readonly IRepository _repository;
        public GetRequestHelpFormVariantHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetRequestHelpFormVariantResponse> Handle(GetRequestHelpFormVariantRequest request, CancellationToken cancellationToken)
        {
            return _repository.GetRequestHelpFormVariant(request.GroupID.Value,request.Source, cancellationToken);
        }
    }
}
