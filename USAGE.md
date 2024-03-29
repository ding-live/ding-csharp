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