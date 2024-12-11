<!-- Start SDK Example Usage [usage] -->
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
    Status = DingSDK.Models.Components.FeedbackRequestStatus.Onboarded,
};

var res = await sdk.Otp.FeedbackAsync(req);

// handle response
```

### Get authentication status

Get the status of an authentication.


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

### Look up for phone number

Perform a phone number lookup.


```csharp
using DingSDK;
using DingSDK.Models.Requests;
using System.Collections.Generic;
using DingSDK.Models.Components;

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