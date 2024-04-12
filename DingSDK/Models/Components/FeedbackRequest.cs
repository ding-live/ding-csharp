
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
    using DingSDK.Models.Components;
    using DingSDK.Utils;
    using Newtonsoft.Json;
    
    public class FeedbackRequest
    {

        /// <summary>
        /// Your customer UUID, which can be found in the API settings in the dashboard.
        /// </summary>
        [JsonProperty("customer_uuid")]
        public string CustomerUuid { get; set; } = default!;

        /// <summary>
        /// An E.164 formatted phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// The type of the feedback.
        /// </summary>
        [JsonProperty("status")]
        public FeedbackRequestStatus Status { get; set; } = default!;
    }
}