using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Contracts.UserService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpClientWrapper _httpClientWrapper;

        public UserService(IHttpClientWrapper httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }
        public async Task<GetUserByIDResponse> GetUserByID(int userID)
        {
            string path = $"api/GetUserByID?ID={userID}";
            using (HttpResponseMessage response = await _httpClientWrapper.GetAsync(HttpClientConfigName.UserService, path, CancellationToken.None).ConfigureAwait(false))
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var userIDResponse = JsonConvert.DeserializeObject<ResponseWrapper<GetUserByIDResponse, UserServiceErrorCode>>(jsonResponse);

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
