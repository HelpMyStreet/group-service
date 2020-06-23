using GroupService.Core.Dto;
using HelpMyStreet.Contracts.GroupService.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Repositories
{
    public interface IRepository
    {
        Task<int> CreateGroupAsync(PostCreateGroupRequest request, CancellationToken cancellationToken);    
    }
}
