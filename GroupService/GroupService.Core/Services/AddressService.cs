using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.AddressService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Contracts.UserService.Request;
using HelpMyStreet.Contracts.UserService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class AddressService : IAddressService
    {
        private readonly IHttpClientWrapper _httpClientWrapper;

        public AddressService(IHttpClientWrapper httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<GetLocationsByDistanceResponse> GetLocationsByDistance(string postCode, int distanceInMiles)
        {
            string path = $"api/GetLocationsByDistance?postcode={postCode}&maxDistance=2000";
            using (HttpResponseMessage response = await _httpClientWrapper.GetAsync(HttpClientConfigName.AddressService, path, CancellationToken.None).ConfigureAwait(false))
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var userIDResponse = JsonConvert.DeserializeObject<ResponseWrapper<GetLocationsByDistanceResponse, UserServiceErrorCode>>(jsonResponse);

                if (userIDResponse.HasContent && userIDResponse.IsSuccessful)
                {
                    return userIDResponse.Content;
                }
                else
                {
                    throw new System.Exception(userIDResponse.Errors.ToString());
                }
            }
        }
    }
}
