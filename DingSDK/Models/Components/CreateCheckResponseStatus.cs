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
    using DingSDK.Utils;
    using Newtonsoft.Json;
    using System;
    
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
    public enum CreateCheckResponseStatus
    {
        [JsonProperty("valid")]
        Valid,
        [JsonProperty("invalid")]
        Invalid,
        [JsonProperty("without_attempt")]
        WithoutAttempt,
        [JsonProperty("rate_limited")]
        RateLimited,
        [JsonProperty("already_validated")]
        AlreadyValidated,
        [JsonProperty("expired_auth")]
        ExpiredAuth,
    }

    public static class CreateCheckResponseStatusExtension
    {
        public static string Value(this CreateCheckResponseStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CreateCheckResponseStatus ToEnum(this string value)
        {
            foreach(var field in typeof(CreateCheckResponseStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is CreateCheckResponseStatus)
                    {
                        return (CreateCheckResponseStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CreateCheckResponseStatus");
        }
    }

}