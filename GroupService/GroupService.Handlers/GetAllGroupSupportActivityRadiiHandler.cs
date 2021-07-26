using GroupService.Core.Exception;
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
    public class GetAllGroupSupportActivityRadiiHandler : IRequestHandler<GetAllGroupSupportActivityRadiiRequest, GetAllGroupSupportActivityRadiiResponse>
    {
        private readonly IRepository _repository;
        public GetAllGroupSupportActivityRadiiHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllGroupSupportActivityRadiiResponse> Handle(GetAllGroupSupportActivityRadiiRequest request, CancellationToken cancellationToken)
        {
            var radii = _repository.GetGroupSupportActivityRadii(cancellationToken);

            return new GetAllGroupSupportActivityRadiiResponse()
            {
               GroupSupportActivityRadii = radii
            };
        }
    }
}
