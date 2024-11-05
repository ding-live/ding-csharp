//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK
{
    using DingSDK.Hooks;
    using DingSDK.Models.Components;
    using DingSDK.Models.Errors;
    using DingSDK.Utils.Retries;
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
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.ding.live/v1",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Ding: The OTP API allows you to send authentication codes to your users using their phone numbers.
    /// </summary>
    public class Ding: IDing
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.19.5";
        private const string _sdkGenVersion = "2.446.5";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.19.5 2.446.5 1.0.0 DingSDK";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<DingSDK.Models.Components.Security>? _securitySource;
        public IOtp Otp { get; private set; }
        public ILookup Lookup { get; private set; }

        public Ding(DingSDK.Models.Components.Security? security = null, Func<DingSDK.Models.Components.Security>? securitySource = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
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

            _client = client ?? new SpeakeasyHttpClient();

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
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Otp = new Otp(_client, _securitySource, _serverUrl, SDKConfiguration);


            Lookup = new Lookup(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}