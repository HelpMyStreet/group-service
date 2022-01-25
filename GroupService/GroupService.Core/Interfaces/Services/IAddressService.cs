using HelpMyStreet.Contracts.AddressService.Response;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IAddressService
    {
        Task<GetLocationsByDistanceResponse> GetLocationsByDistance(string postCode, int distanceInMiles);        
    }
}
