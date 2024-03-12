
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
    
    public class CreateAuthenticationRequest
    {

        /// <summary>
        /// The Android SMS Retriever API hash code that identifies your app. This allows you to automatically retrieve and fill the OTP code on Android devices.
        /// </summary>
        [JsonProperty("app_realm")]
        public string? AppRealm { get; set; }

        /// <summary>
        /// The version of your application.
        /// </summary>
        [JsonProperty("app_version")]
        public string? AppVersion { get; set; }

        /// <summary>
        /// A webhook URL to which delivery statuses will be sent.
        /// </summary>
        [JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Your customer UUID, which can be found in the API settings in the dashboard.
        /// </summary>
        [JsonProperty("customer_uuid")]
        public string CustomerUuid { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the user&apos;s device. For Android, this corresponds to the `ANDROID_ID` and for iOS, this corresponds to the `identifierForVendor`.
        /// </summary>
        [JsonProperty("device_id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// The model of the user&apos;s device.
        /// </summary>
        [JsonProperty("device_model")]
        public string? DeviceModel { get; set; }

        /// <summary>
        /// The type of device the user is using.
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceType? DeviceType { get; set; }

        /// <summary>
        /// The IP address of the user&apos;s device.
        /// </summary>
        [JsonProperty("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Whether the user is a returning user on your app.
        /// </summary>
        [JsonProperty("is_returning_user")]
        public bool? IsReturningUser { get; set; }

        /// <summary>
        /// The version of the user&apos;s device operating system.
        /// </summary>
        [JsonProperty("os_version")]
        public string? OsVersion { get; set; }

        /// <summary>
        /// An E.164 formatted phone number to send the OTP to.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// The template id associated with the message content variant to be sent.
        /// </summary>
        [JsonProperty("template_id")]
        public string? TemplateId { get; set; }
    }
}