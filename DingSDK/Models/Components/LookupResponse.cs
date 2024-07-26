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
    
    public class LookupResponse
    {

        /// <summary>
        /// The carrier of the phone number.
        /// </summary>
        [JsonProperty("carrier")]
        public string? Carrier { get; set; }

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code of the phone number.
        /// </summary>
        [JsonProperty("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// The type of phone line.
        /// </summary>
        [JsonProperty("line_type")]
        public LineType? LineType { get; set; }

        /// <summary>
        /// The mobile country code of the phone number.
        /// </summary>
        [JsonProperty("mcc")]
        public string? Mcc { get; set; }

        /// <summary>
        /// The mobile network code of the phone number.
        /// </summary>
        [JsonProperty("mnc")]
        public string? Mnc { get; set; }

        /// <summary>
        /// Whether the phone number has been ported.
        /// </summary>
        [JsonProperty("number_ported")]
        public bool? NumberPorted { get; set; }

        /// <summary>
        /// An E.164 formatted phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}