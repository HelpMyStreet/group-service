using HelpMyStreet.Contracts.CommunicationService.Request;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface ICommunicationService
    {
        Task<bool> RequestCommunication(RequestCommunicationRequest request, CancellationToken cancellationToken);
    }
}
