using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface ITargetGroupService
    {
        Task<IEnumerable<int>> GetTargetGroups(int referringGroupId, string source, CancellationToken cancellationToken);
        Task<IEnumerable<int>> GetTargetGroupsMembers(int referringGroupId, string source, CancellationToken cancellationToken);
    }
}
