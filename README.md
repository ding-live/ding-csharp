# DingSDK

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/ding-live/ding-csharp.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/ding-live/ding-csharp/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>


## 🏗 **Welcome to your new SDK!** 🏗

It has been generated successfully based on your OpenAPI spec. However, it is not yet ready for production use. Here are some next steps:
- [ ] 🛠 Make your SDK feel handcrafted by [customizing it](https://www.speakeasyapi.dev/docs/customize-sdks)
- [ ] ♻️ Refine your SDK quickly by iterating locally with the [Speakeasy CLI](https://github.com/speakeasy-api/speakeasy)
- [ ] 🎁 Publish your SDK to package managers by [configuring automatic publishing](https://www.speakeasyapi.dev/docs/productionize-sdks/publish-sdks)
- [ ] ✨ When ready to productionize, delete this section from the README
<!-- Start SDK Installation -->
# SDK Installation

## Nuget

```bash
dotnet add package DingSDK
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->

# Send a code
Send an OTP code to a user's phone number.

```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

var res = await sdk.Otp.CreateAutenticationAsync(new CreateAuthenticationRequest() {
    CustomerUuid = "eae192ab-9e1e-4b21-b5b1-bfcb79a32fcc",
    PhoneNumber = "+1234567890",
});

// handle response
```


# Check a code
Check that a code entered by a user is valid.

```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

var res = await sdk.Otp.CheckAsync(new CreateCheckRequest() {
    AuthenticationUuid = "e0e7b0e9-739d-424b-922f-1c2cb48ab077",
    CheckCode = "123456",
    CustomerUuid = "8f1196d5-806e-4b71-9b24-5f96ec052808",
});

// handle response
```


# Retry an authentication
Retry an authentication if a user has not received the code.

```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

var res = await sdk.Otp.RetryAsync(new RetryAuthenticationRequest() {
    AuthenticationUuid = "a74ee547-564d-487a-91df-37fb25413a91",
    CustomerUuid = "3c8b3a46-881e-4cdd-93a6-f7f238bf020a",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
# Available Resources and Operations


## [Otp](docs/sdks/otp/README.md)

* [Check](docs/sdks/otp/README.md#check) - Check an authentication code
* [CreateAutentication](docs/sdks/otp/README.md#createautentication) - Create an authentication
* [Retry](docs/sdks/otp/README.md#retry) - Retry an authentication

## [Lookup](docs/sdks/lookup/README.md)

* [Lookup](docs/sdks/lookup/README.md#lookup) - Lookup a phone number
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->



<!-- End Dev Containers -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
