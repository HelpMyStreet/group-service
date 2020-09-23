using GroupService.Core.Services;
using HelpMyStreet.Contracts.UserService.Response;
using HelpMyStreet.Utils.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IExpiredService
    {
        Task ExpireVolunteers(int expiredDays, CancellationToken cancellationToken);
    }
}
