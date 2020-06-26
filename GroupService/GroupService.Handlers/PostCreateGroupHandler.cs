using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class PostCreateGroupHandler : IRequestHandler<PostCreateGroupRequest, PostCreateGroupResponse>
    {
        private readonly IRepository _repository;
        public PostCreateGroupHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<PostCreateGroupResponse> Handle(PostCreateGroupRequest request, CancellationToken cancellationToken)
        {
            int groupId = await _repository.CreateGroupAsync(request, cancellationToken);
            return new PostCreateGroupResponse()
            {
                GroupId = groupId
            };
        }
    }
}
