# Lookup
(*Lookup*)

## Overview

Retrieve up-to-date metadata about a specific phone number

### Available Operations

* [Lookup](#lookup) - Perform a phone number lookup

## Lookup

Perform a phone number lookup

### Example Usage

```csharp
using DingSDK;
using DingSDK.Models.Components;
using DingSDK.Models.Requests;

var sdk = new Ding(
    security: new Security() {
        APIKey = "YOUR_API_KEY",
    }
);

var res = await sdk.Lookup.LookupAsync("6e93aa15-9177-4d09-8395-b69ce50db1c8", "string");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `CustomerUuid`     | *string*           | :heavy_check_mark: | N/A                |
| `PhoneNumber`      | *string*           | :heavy_check_mark: | N/A                |


### Response

**[Models.Requests.LookupResponse](../../Models/Requests/LookupResponse.md)**

