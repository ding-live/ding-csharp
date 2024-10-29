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
    
    /// <summary>
    /// <a href="/guides/prevent-fraud#signals">Signals</a> are data points used to distinguish between fraudulent and legitimate users.
    /// </summary>
    public class Signals
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
        public AuthenticationStatusResponseDeviceType? DeviceType { get; set; }

        /// <summary>
        /// The IP address of the user&apos;s device.
        /// </summary>
        [JsonProperty("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// This signal should do more than just confirm if a user is returning to your app; it should provide a higher level of trust, indicating that the user is genuine. For more details, refer to <a href="/guides/prevent-fraud#signals">Signals</a>.
        /// </summary>
        [JsonProperty("is_returning_user")]
        public bool? IsReturningUser { get; set; }

        /// <summary>
        /// The version of the user&apos;s device operating system.
        /// </summary>
        [JsonProperty("os_version")]
        public string? OsVersion { get; set; }
    }
}