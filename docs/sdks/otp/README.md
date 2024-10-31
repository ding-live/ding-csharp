# Otp
(*Otp*)

## Overview

Send OTP codes to your users using their phone numbers.

### Available Operations

* [Check](#check) - Check a code
* [CreateAuthentication](#createauthentication) - Send a code
* [Feedback](#feedback) - Send feedback
* [GetAuthenticationStatus](#getauthenticationstatus) - Get authentication status
* [Retry](#retry) - Perform a retry

## Check

Check a code

### Example Usage

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

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CreateCheckRequest](../../Models/Components/CreateCheckRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CheckResponse](../../Models/Requests/CheckResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |

## CreateAuthentication

Send a code

### Example Usage

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

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [CreateAuthenticationRequest](../../Models/Components/CreateAuthenticationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[Models.Requests.CreateAuthenticationResponse](../../Models/Requests/CreateAuthenticationResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |

## Feedback

Send feedback

### Example Usage

```csharp
using DingSDK;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

FeedbackRequest req = new FeedbackRequest() {
    CustomerUuid = "cc0f6c04-40de-448f-8301-3cb0e6565dff",
    PhoneNumber = "+1234567890",
    Status = DingSDK.Models.Components.FeedbackRequestStatus.Onboarded,
};

var res = await sdk.Otp.FeedbackAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [FeedbackRequest](../../Models/Components/FeedbackRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[Models.Requests.FeedbackResponse](../../Models/Requests/FeedbackResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |

## GetAuthenticationStatus

Get authentication status

### Example Usage

```csharp
using DingSDK;
using DingSDK.Models.Requests;
using DingSDK.Models.Components;

var sdk = new Ding(security: new Security() {
    APIKey = "YOUR_API_KEY",
});

var res = await sdk.Otp.GetAuthenticationStatusAsync(authUuid: "d8446450-f2fa-4dd9-806b-df5b8c661f23");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AuthUuid`         | *string*           | :heavy_check_mark: | N/A                |

### Response

**[GetAuthenticationStatusResponse](../../Models/Requests/GetAuthenticationStatusResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |

## Retry

Perform a retry

### Example Usage

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

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [RetryAuthenticationRequest](../../Models/Components/RetryAuthenticationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[RetryResponse](../../Models/Requests/RetryResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |