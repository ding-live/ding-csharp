//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace DingSDK.Models.Requests
{
    using DingSDK.Utils;
    
    public class GetAuthenticationStatusRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=auth_uuid")]
        public string AuthUuid { get; set; } = default!;
    }
}