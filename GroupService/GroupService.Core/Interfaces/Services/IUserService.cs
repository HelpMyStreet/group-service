using GroupService.Core.Services;
using HelpMyStreet.Utils.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<GetUserByIDResponse> GetUserByID(int userID);
    }
}
