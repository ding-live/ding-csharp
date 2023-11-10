
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Models.Components
{
    using Newtonsoft.Json;
    
    public class ErrorResponse
    {

        /// <summary>
        /// A machine-readable code that describes the error. Possible values are:<br/>
        /// 
        /// <remarks>
        ///   * `invalid_phone_number` - This is not a valid E.164 number.<br/>
        ///   * `internal_server_error` - An internal server error occurred.<br/>
        ///   * `bad_request` - The request was malformed.<br/>
        ///   * `account_invalid` - The customer UUID you provided is invalid.<br/>
        ///   * `negative_balance` - You have a negative balance.<br/>
        ///   * `invalid_line` - Ding does not support this type of phone number.<br/>
        ///   * `unsupported_region` - Ding does not support this region yet.<br/>
        ///   * `invalid_auth_uuid` - The authentication UUID you provided is invalid.<br/>
        ///   * `blocked_number` - The phone number you provided is in the blocklist.<br/>
        ///   * `invalid_app_version` - The app version you provided is invalid.<br/>
        ///   * `invalid_os_version` - The OS version you provided is invalid.<br/>
        ///   * `invalid_device_model` - The device model you provided is invalid.<br/>
        ///   * `invalid_device_id` - The device ID you provided is invalid.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("code")]
        public Code? Code { get; set; }

        /// <summary>
        /// A link to the documentation that describes the error.
        /// </summary>
        [JsonProperty("doc_url")]
        public string? DocUrl { get; set; }

        /// <summary>
        /// A human-readable message that describes the error.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}