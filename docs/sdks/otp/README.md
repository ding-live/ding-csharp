# Otp
(*Otp*)

## Overview

Send OTP codes to your users using their phone numbers.

### Available Operations

* [Check](#check) - Check an authentication code
* [Retry](#retry) - Retry an authentication
* [Send](#send) - Create an authentication

## Check

Check an authentication code

### Example Usage

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

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CreateCheckRequest](../../Models/Components/CreateCheckRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[CheckResponse](../../Models/Requests/CheckResponse.md)**


## Retry

Retry an authentication

### Example Usage

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

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [RetryAuthenticationRequest](../../Models/Components/RetryAuthenticationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[RetryResponse](../../Models/Requests/RetryResponse.md)**


## Send

Create an authentication

### Example Usage

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

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [CreateAuthenticationRequest](../../Models/Components/CreateAuthenticationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[CreateAutenticationResponse](../../Models/Requests/CreateAutenticationResponse.md)**

