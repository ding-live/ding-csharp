//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    
    public class CreateCheckResponse
    {

        /// <summary>
        /// The UUID of the corresponding authentication.
        /// </summary>
        [JsonProperty("authentication_uuid")]
        public string? AuthenticationUuid { get; set; }

        /// <summary>
        /// The status of the check. Possible values are:<br/>
        /// 
        /// <remarks>
        ///   * `valid` - The code is valid.<br/>
        ///   * `invalid` - The code is invalid.<br/>
        ///   * `without_attempt` - No attempt was sent yet, so a check cannot be completed.<br/>
        ///   * `rate_limited` - The authentication was rate limited and cannot be checked.<br/>
        ///   * `already_validated` - The authentication has already been validated.<br/>
        ///   * `expired_auth` - The authentication has expired and cannot be checked.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public CreateCheckResponseStatus? Status { get; set; }
    }
}