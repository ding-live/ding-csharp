# Ding C# SDK

The Ding C# library provides convenient access to the Ding API from applications written in C#.

<!-- Start Summary [summary] -->
## Summary

Ding: The OTP API allows you to send authentication codes to your users using their phone numbers.
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Ding C# SDK](#ding-c-sdk)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [SDK Example Usage](#sdk-example-usage-1)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server Selection](#server-selection)
  * [Authentication](#authentication)
  * [Error Handling](#error-handling)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package DingSDK
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference DingSDK/DingSDK.csproj
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
    CustomerUuid = "cf2edc1c-7fc6-48fb-86da-b7508c6b7b71",
    Locale = "fr-FR",
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
    AuthenticationUuid = "eebe792b-2fcc-44a0-87f1-650e79259e02",
    CheckCode = "123456",
    CustomerUuid = "64f66a7c-4b2c-4131-a8ff-d5b954cca05f",
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
    AuthenticationUuid = "a4e4548a-1f7b-451a-81cb-a68ed5aff3b0",
    CustomerUuid = "28532118-1b33-420a-b57b-648c9bf85fee",
};

var res = await sdk.Otp.RetryAsync(req);

// handle response
```

### Send feedback

Send feedback about the authentication process.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

FeedbackRequest req = new FeedbackRequest() {
    CustomerUuid = "cc0f6c04-40de-448f-8301-3cb0e6565dff",
    PhoneNumber = "+1234567890",
    Status = FeedbackRequestStatus.Onboarded,
};

var res = await sdk.Otp.FeedbackAsync(req);

// handle response
```

### Get authentication status

Get the status of an authentication.


```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

var res = await sdk.Otp.GetAuthenticationStatusAsync(authUuid: "d8446450-f2fa-4dd9-806b-df5b8c661f23");

// handle response
```

### Look up for phone number

Perform a phone number lookup.


```csharp
using DingSDK;
using DingSDK.Models.Components;
using DingSDK.Models.Requests;
using System.Collections.Generic;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

var res = await sdk.Lookup.LookupAsync(
    customerUuid: "69a197d9-356c-45d1-a807-41874e16b555",
    phoneNumber: "<value>",
    type: new List<DingSDK.Models.Requests.Type>() {
        DingSDK.Models.Requests.Type.Cnam,
    }
);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>


### [Lookup](docs/sdks/lookup/README.md)

* [Lookup](docs/sdks/lookup/README.md#lookup) - Look up for phone number

### [Otp](docs/sdks/otp/README.md)

* [Check](docs/sdks/otp/README.md#check) - Check a code
* [CreateAuthentication](docs/sdks/otp/README.md#createauthentication) - Send a code
* [Feedback](docs/sdks/otp/README.md#feedback) - Send feedback
* [GetAuthenticationStatus](docs/sdks/otp/README.md#getauthenticationstatus) - Get authentication status
* [Retry](docs/sdks/otp/README.md#retry) - Perform a retry

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(
    serverUrl: "https://api.ding.live/v1",
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

CreateCheckRequest req = new CreateCheckRequest() {
    AuthenticationUuid = "eebe792b-2fcc-44a0-87f1-650e79259e02",
    CheckCode = "123456",
    CustomerUuid = "64f66a7c-4b2c-4131-a8ff-d5b954cca05f",
};

var res = await sdk.Otp.CheckAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name     | Type   | Scheme  |
| -------- | ------ | ------- |
| `APIKey` | apiKey | API key |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

CreateCheckRequest req = new CreateCheckRequest() {
    AuthenticationUuid = "eebe792b-2fcc-44a0-87f1-650e79259e02",
    CheckCode = "123456",
    CustomerUuid = "64f66a7c-4b2c-4131-a8ff-d5b954cca05f",
};

var res = await sdk.Otp.CheckAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `DingSDK.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CheckAsync` method throws the following exceptions:

| Error Type                          | Status Code | Content Type     |
| ----------------------------------- | ----------- | ---------------- |
| DingSDK.Models.Errors.ErrorResponse | 400         | application/json |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using DingSDK;
using DingSDK.Models.Components;
using DingSDK.Models.Errors;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

try
{
    CreateCheckRequest req = new CreateCheckRequest() {
        AuthenticationUuid = "eebe792b-2fcc-44a0-87f1-650e79259e02",
        CheckCode = "123456",
        CustomerUuid = "64f66a7c-4b2c-4131-a8ff-d5b954cca05f",
    };

    var res = await sdk.Otp.CheckAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorResponse)
    {
        // Handle exception data
        throw;
    }
    else if (ex is DingSDK.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!
