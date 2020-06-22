using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.GroupService.Request;
using MediatR;
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
            ///PostCreateGroupResponse response = _repository.GetJobDetails(request.JobID);
            return new PostCreateGroupResponse();
        }
    }
}
