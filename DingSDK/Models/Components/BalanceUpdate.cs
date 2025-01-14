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
    using System;
    
    public class BalanceUpdate
    {

        /// <summary>
        /// The amount of the balance update.
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("balance_update_type")]
        public BalanceUpdateType? BalanceUpdateType { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The type of the event.
        /// </summary>
        [JsonProperty("type")]
        public AuthenticationStatusResponseSchemasEventsType? Type { get; set; }
    }
}