using GroupService.Core.Services;
using HelpMyStreet.Contracts.UserService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<GetUserByIDResponse> GetUserByID(int userID);
        Task<IEnumerable<VolunteerSummary>> GetVolunteersByPostcodeAndActivity(string postcode, List<SupportActivities> activities, double? shiftRadius, CancellationToken cancellationToken);        
    }
}
