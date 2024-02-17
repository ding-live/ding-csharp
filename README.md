# Ding C# SDK

The Ding C# library provides convenient access to the Ding API from applications written in C#.

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package DingSDK
```
<!-- End SDK Installation [installation] -->

## SDK Example Usage

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Send a code

Send an OTP code to a user's phone number.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
        APIKey = "YOUR_API_KEY",
    });

CreateAuthenticationRequest req = new CreateAuthenticationRequest() {
    CustomerUuid = "eae192ab-9e1e-4b21-b5b1-bfcb79a32fcc",
    PhoneNumber = "+1234567890",
};

var res = await sdk.Otp.CreateAutenticationAsync(req);

// handle response
```

### Check a code

Check that a code entered by a user is valid.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
        APIKey = "YOUR_API_KEY",
    });

CreateCheckRequest req = new CreateCheckRequest() {
    AuthenticationUuid = "e0e7b0e9-739d-424b-922f-1c2cb48ab077",
    CheckCode = "123456",
    CustomerUuid = "8f1196d5-806e-4b71-9b24-5f96ec052808",
};

var res = await sdk.Otp.CheckAsync(req);

// handle response
```

### Perform a retry

Perform a retry if a user has not received the code.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
        APIKey = "YOUR_API_KEY",
    });

RetryAuthenticationRequest req = new RetryAuthenticationRequest() {
    AuthenticationUuid = "a74ee547-564d-487a-91df-37fb25413a91",
    CustomerUuid = "3c8b3a46-881e-4cdd-93a6-f7f238bf020a",
};

var res = await sdk.Otp.RetryAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Otp](docs/sdks/otp/README.md)

* [Check](docs/sdks/otp/README.md#check) - Check a code
* [CreateAutentication](docs/sdks/otp/README.md#createautentication) - Send a code
* [Retry](docs/sdks/otp/README.md#retry) - Perform a retry

### [Lookup](docs/sdks/lookup/README.md)

* [Lookup](docs/sdks/lookup/README.md#lookup) - Perform a phone number lookup
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name | Server | Variables |
| ----- | ------ | --------- |
| `production` | `https://api.ding.live/v1` | None |



### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name     | Type     | Scheme   |
| -------- | -------- | -------- |
| `APIKey` | apiKey   | API key  |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
        APIKey = "YOUR_API_KEY",
    });

CreateCheckRequest req = new CreateCheckRequest() {
    AuthenticationUuid = "e0e7b0e9-739d-424b-922f-1c2cb48ab077",
    CheckCode = "123456",
    CustomerUuid = "8f1196d5-806e-4b71-9b24-5f96ec052808",
};

var res = await sdk.Otp.CheckAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!
