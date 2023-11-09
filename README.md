# Ding C# SDK

The Ding C# library provides convenient access to the Ding API from applications written in C#.

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package DingSDK
```
<!-- End SDK Installation -->

## SDK Example Usage

<!-- Start SDK Example Usage -->
### Send a code

Send an OTP code to a user's phone number.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

var res = await sdk.Otp.SendAsync(new CreateAuthenticationRequest() {
    CustomerUuid = "82779012-9667-4917-8532-b94017ce3f0f",
    PhoneNumber = "+1234567890",
});

// handle response
```

### Check a code

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

### Retry an authentication

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
## Available Resources and Operations


### [Otp](docs/sdks/otp/README.md)

* [Check](docs/sdks/otp/README.md#check) - Check an authentication code
* [Retry](docs/sdks/otp/README.md#retry) - Retry an authentication
* [Send](docs/sdks/otp/README.md#send) - Create an authentication

### [Lookup](docs/sdks/lookup/README.md)

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
