
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
    using DingSDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    /// <summary>
    /// Ding: The OTP API allows you to send authentication codes to your users using their phone numbers.
    /// </summary>
    public interface IDing
    {

        /// <summary>
        /// Send OTP codes to your users using their phone numbers.
        /// </summary>
        public IOtp Otp { get; }

        /// <summary>
        /// Retrieve up-to-date metadata about a specific phone number
        /// </summary>
        public ILookup Lookup { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "https://api.ding.live/v1",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    /// <summary>
    /// Ding: The OTP API allows you to send authentication codes to your users using their phone numbers.
    /// </summary>
    public class Ding: IDing
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.11.0";
        private const string _sdkGenVersion = "2.277.0";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.11.0 2.277.0 1.0.0 DingSDK";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IOtp Otp { get; private set; }
        public ILookup Lookup { get; private set; }

        public Ding(Security? security = null, Func<Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(securitySource != null)
            {
                _securitySource = securitySource;
            }
            else if(security != null)
            {
                _securitySource = () => security;
            }
            else
            {
                throw new Exception("security and securitySource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Otp = new Otp(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
            Lookup = new Lookup(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}
