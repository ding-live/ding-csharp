# Otp
(*Otp*)

## Overview

Send OTP codes to your users using their phone numbers.

### Available Operations

* [Check](#check) - Check a code
* [CreateAuthentication](#createauthentication) - Send a code
* [Feedback](#feedback) - Send feedback
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
    AuthenticationUuid = "e0e7b0e9-739d-424b-922f-1c2cb48ab077",
    CheckCode = "123456",
    CustomerUuid = "8f1196d5-806e-4b71-9b24-5f96ec052808",
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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |

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
    CustomerUuid = "c9f826e0-deca-41ec-871f-ecd6e8efeb46",
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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |

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
    CustomerUuid = "c0c405fa-6bcb-4094-9430-7d6e2428ff23",
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

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| DingSDK.Models.Errors.SDKException | 4xx-5xx                            | */*                                |

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
    AuthenticationUuid = "a74ee547-564d-487a-91df-37fb25413a91",
    CustomerUuid = "3c8b3a46-881e-4cdd-93a6-f7f238bf020a",
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

| Error Object                        | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4xx-5xx                             | */*                                 |
