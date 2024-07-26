//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Models.Components
{
    using DingSDK.Models.Components;
    using DingSDK.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// A successful response to an authentication creation request.
    /// </summary>
    public class CreateAuthenticationResponse
    {

        /// <summary>
        /// A unique identifier for the authentication that you can use on the /check and /retry endpoints.
        /// </summary>
        [JsonProperty("authentication_uuid")]
        public string? AuthenticationUuid { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time at which the authentication expires and can no longer be checked or retried.
        /// </summary>
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The status of the authentication. Possible values are:<br/>
        /// 
        /// <remarks>
        ///   * `pending` - The OTP code is being sent.<br/>
        ///   * `rate_limited` - This user is rate-limited and cannot receive another code.<br/>
        ///   * `spam_detected` - This attempt is flagged as spam. Go to the dashboard for more details.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public Status? Status { get; set; }
    }
}