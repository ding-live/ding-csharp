
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
        /// Lookup a phone number
        /// </summary>
        Task<Models.Requests.LookupResponse> LookupAsync(string customerUuid, Models.Components.LookupRequest? lookupRequest = null);
    }

    /// <summary>
    /// Retrieve up-to-date metadata about a specific phone number
    /// </summary>
    public class Lookup: ILookup
    {
        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.185.0";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.185.0 1.0.0 DingSDK";
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
        

        public async Task<Models.Requests.LookupResponse> LookupAsync(string customerUuid, Models.Components.LookupRequest? lookupRequest = null)
        {
            var request = new Models.Requests.LookupRequest()
            {
                CustomerUuid = customerUuid,
                LookupRequestValue = lookupRequest,
            };
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = baseUrl + "/lookup";
            

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "LookupRequestValue", "json");
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }
            
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