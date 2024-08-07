//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Models.Errors
{
    using DingSDK.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// A machine-readable code that describes the error.
    /// </summary>
    public enum Code
    {
        [JsonProperty("invalid_phone_number")]
        InvalidPhoneNumber,
        [JsonProperty("internal_server_error")]
        InternalServerError,
        [JsonProperty("bad_request")]
        BadRequest,
        [JsonProperty("account_invalid")]
        AccountInvalid,
        [JsonProperty("negative_balance")]
        NegativeBalance,
        [JsonProperty("invalid_line")]
        InvalidLine,
        [JsonProperty("unsupported_region")]
        UnsupportedRegion,
        [JsonProperty("invalid_auth_uuid")]
        InvalidAuthUuid,
        [JsonProperty("invalid_app_realm")]
        InvalidAppRealm,
        [JsonProperty("unsupported_app_realm_device_type")]
        UnsupportedAppRealmDeviceType,
        [JsonProperty("app_realm_require_device_type")]
        AppRealmRequireDeviceType,
        [JsonProperty("blocked_number")]
        BlockedNumber,
        [JsonProperty("invalid_app_version")]
        InvalidAppVersion,
        [JsonProperty("invalid_os_version")]
        InvalidOsVersion,
        [JsonProperty("invalid_device_model")]
        InvalidDeviceModel,
        [JsonProperty("invalid_device_id")]
        InvalidDeviceId,
        [JsonProperty("no_associated_auth_found")]
        NoAssociatedAuthFound,
        [JsonProperty("duplicated_feedback_status")]
        DuplicatedFeedbackStatus,
        [JsonProperty("invalid_feedback_status")]
        InvalidFeedbackStatus,
        [JsonProperty("invalid_template_id")]
        InvalidTemplateId,
        [JsonProperty("suspended_account")]
        SuspendedAccount,
    }

    public static class CodeExtension
    {
        public static string Value(this Code value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Code ToEnum(this string value)
        {
            foreach(var field in typeof(Code).GetFields())
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

                    if (enumVal is Code)
                    {
                        return (Code)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Code");
        }
    }

}