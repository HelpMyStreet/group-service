using HelpMyStreet.Contracts.RequestService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IRequestService
    {
        Task<GetJobsByFilterResponse> GetJobsByFilter(GetJobsByFilterRequest getJobsByFilterRequest);
    }
}
