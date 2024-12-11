# Lookup
(*Lookup*)

## Overview

Retrieve up-to-date metadata about a specific phone number

### Available Operations

* [Lookup](#lookup) - Look up for phone number

## Lookup

Look up for phone number

### Example Usage

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

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `CustomerUuid`                                              | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `PhoneNumber`                                               | *string*                                                    | :heavy_check_mark:                                          | N/A                                                         |
| `Type`                                                      | List<[Models.Requests.Type](../../Models/Requests/Type.md)> | :heavy_minus_sign:                                          | N/A                                                         |

### Response

**[Models.Requests.LookupResponse](../../Models/Requests/LookupResponse.md)**

### Errors

| Error Type                          | Status Code                         | Content Type                        |
| ----------------------------------- | ----------------------------------- | ----------------------------------- |
| DingSDK.Models.Errors.ErrorResponse | 400                                 | application/json                    |
| DingSDK.Models.Errors.SDKException  | 4XX, 5XX                            | \*/\*                               |