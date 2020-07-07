using GroupService.Core.Config;
using GroupService.Core.Interfaces.Services;
using GroupService.Core.Interfaces.Utils;
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
            GetUserByIDResponse usersResponse;
            using (HttpResponseMessage response = await _httpClientWrapper.GetAsync(HttpClientConfigName.UserService, path, CancellationToken.None).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                usersResponse = JsonConvert.DeserializeObject<GetUserByIDResponse>(content);
            }
            return usersResponse;
        }
    }
}
