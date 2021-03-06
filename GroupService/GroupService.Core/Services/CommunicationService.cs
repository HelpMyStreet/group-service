﻿using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.CommunicationService.Request;
using HelpMyStreet.Contracts.CommunicationService.Response;
using HelpMyStreet.Contracts.Shared;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        private readonly IHttpClientWrapper _httpClientWrapper;

        public CommunicationService(IHttpClientWrapper httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<bool> RequestCommunication(RequestCommunicationRequest request, CancellationToken cancellationToken)
        {
            string path = $"api/RequestCommunication";
            var jsonContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await _httpClientWrapper.PostAsync(HttpClientConfigName.CommunicationService, path, jsonContent, cancellationToken).ConfigureAwait(false))
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var requestCommunicationResponse = JsonConvert.DeserializeObject<ResponseWrapper<RequestCommunicationResponse, CommunicationServiceErrorCode>>(jsonResponse);
                if (requestCommunicationResponse.HasContent && requestCommunicationResponse.IsSuccessful)
                {
                    return requestCommunicationResponse.Content.Success;
                }
                return false;
            }
        }
    }
}
