
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
        public static Dictionary<string, string> ServerList = new Dictionary<string, string>()
        {
            {"Serverproduction", "https://api.ding.live/v1" },
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public string server = "";

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            if (!String.IsNullOrEmpty(this.server))
            {
                this.server = "Serverproduction";
            }
            Dictionary<string, string> serverDefault = new Dictionary<string, string>();
            

            return Utilities.TemplateUrl(SDKConfig.ServerList[this.server], serverDefault);
        }
    }

    /// <summary>
    /// Ding: The OTP API allows you to send authentication codes to your users using their phone numbers.
    /// </summary>
    public class Ding: IDing
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.7.1";
        private const string _sdkGenVersion = "2.237.2";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.7.1 2.237.2 1.0.0 DingSDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IOtp Otp { get; private set; }
        public ILookup Lookup { get; private set; }

        public Ding(Security? security = null, string? server = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverUrl != null) {
                if (urlParams != null) {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            SDKConfiguration = new SDKConfig()
            {
                serverUrl = _serverUrl
            };

            Otp = new Otp(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
            Lookup = new Lookup(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}