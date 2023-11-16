
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK
{
    using DingSDK.Models.Components;
    using DingSDK.Models.Requests;
    using DingSDK.Utils;
    using Newtonsoft.Json;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Retrieve up-to-date metadata about a specific phone number
    /// </summary>
    public interface ILookup
    {

        /// <summary>
        /// Perform a phone number lookup
        /// </summary>
        Task<Models.Requests.LookupResponse> LookupAsync(string customerUuid, string phoneNumber);
    }

    /// <summary>
    /// Retrieve up-to-date metadata about a specific phone number
    /// </summary>
    public class Lookup: ILookup
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.6.0";
        private const string _sdkGenVersion = "2.192.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.6.0 2.192.1 1.0.0 DingSDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Lookup(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        public async Task<Models.Requests.LookupResponse> LookupAsync(string customerUuid, string phoneNumber)
        {
            var request = new LookupRequest()
            {
                CustomerUuid = customerUuid,
                PhoneNumber = phoneNumber,
            };
            string baseUrl = this.Config.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lookup/{phone_number}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new Models.Requests.LookupResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.LookupResponseValue = JsonConvert.DeserializeObject<Models.Components.LookupResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}