using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.RequestService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class RequestService : IRequestService
    {
        private readonly IHttpClientWrapper _httpClientWrapper;

        public RequestService(IHttpClientWrapper httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<GetJobsByFilterResponse> GetJobsByFilter(GetJobsByFilterRequest getJobsByFilterRequest)
        {
            string path = $"api/GetJobsByFilter";

            ResponseWrapper<GetJobsByFilterResponse, GroupServiceErrorCode> getJobsByFilterResponseWithWrapper;

            using (HttpResponseMessage response = await _httpClientWrapper.GetAsync(
                HttpClientConfigName.RequestService,
                path,
                getJobsByFilterRequest,
                CancellationToken.None).ConfigureAwait(false))
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                getJobsByFilterResponseWithWrapper = JsonConvert.DeserializeObject<ResponseWrapper<GetJobsByFilterResponse, GroupServiceErrorCode>>(jsonResponse);

                if (getJobsByFilterResponseWithWrapper.HasContent && getJobsByFilterResponseWithWrapper.IsSuccessful)
                {
                    return getJobsByFilterResponseWithWrapper.Content;
                }
            }
            throw new System.Exception($"GetJobsByFilter failed with exception");
        }
    }
}