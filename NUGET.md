# DingSDK

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<!-- Start Installation [installation] -->
## Installation

```bash
dotnet add package DingSDK
```
<!-- End Installation [installation] -->

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
    CustomerUuid = "c9f826e0-deca-41ec-871f-ecd6e8efeb46",
    PhoneNumber = "+1234567890",
};

var res = await sdk.Otp.CreateAuthenticationAsync(req);

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

- [Ding SDK](https:/github.com/ding-live/ding-csharp/blob/main/github/workspace/repo/docs/sdks/ding/README.md#available-operations)
- [Otp](https:/github.com/ding-live/ding-csharp/blob/main/github/workspace/repo/docs/sdks/otp/README.md#available-operations)
- [Lookup](https:/github.com/ding-live/ding-csharp/blob/main/github/workspace/repo/docs/sdks/lookup/README.md#available-operations)
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |

### Example

```csharp
using DingSDK;
using DingSDK.Models.Components;
using System;
using DingSDK.Models.Errors;

var sdk = new Ding(security: new Security() {
        APIKey = "YOUR_API_KEY",
    });

CreateCheckRequest req = new CreateCheckRequest() {
    AuthenticationUuid = "e0e7b0e9-739d-424b-922f-1c2cb48ab077",
    CheckCode = "123456",
    CustomerUuid = "8f1196d5-806e-4b71-9b24-5f96ec052808",
};

try
{
    var res = await sdk.Otp.CheckAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorResponse)
    {
        // handle exception
    }
    else if (ex is DingSDK.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.ding.live/v1` | None |




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