# Attempt


## Fields

| Field                                                                                                                                                                                                                                                                                                                          | Type                                                                                                                                                                                                                                                                                                                           | Required                                                                                                                                                                                                                                                                                                                       | Description                                                                                                                                                                                                                                                                                                                    | Example                                                                                                                                                                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AttemptNumber`                                                                                                                                                                                                                                                                                                                | *long*                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The attempt number.                                                                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                                                |
| `Capability`                                                                                                                                                                                                                                                                                                                   | [Capability](../../Models/Components/Capability.md)                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The capability of the attempt.                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                                                |
| `Content`                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The content of the attempt.                                                                                                                                                                                                                                                                                                    | Your code is 123456                                                                                                                                                                                                                                                                                                            |
| `CreatedAt`                                                                                                                                                                                                                                                                                                                    | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | N/A                                                                                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                                                |
| `Id`                                                                                                                                                                                                                                                                                                                           | *string*                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The ID of the attempt.                                                                                                                                                                                                                                                                                                         |                                                                                                                                                                                                                                                                                                                                |
| `SenderId`                                                                                                                                                                                                                                                                                                                     | *string*                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The sender ID of the attempt.                                                                                                                                                                                                                                                                                                  |                                                                                                                                                                                                                                                                                                                                |
| `Status`                                                                                                                                                                                                                                                                                                                       | [AuthenticationStatusResponseSchemasStatus](../../Models/Components/AuthenticationStatusResponseSchemasStatus.md)                                                                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The status of the attempt. Possible values are:<br/>  * `pending` - The attempt is pending.<br/>  * `delivered` - The attempt was delivered.<br/>  * `failed` - The attempt failed.<br/>  * `rate_limited` - The authentication was rate limited and cannot be retried.<br/>  * `expired` - The authentication has expired and cannot be retried.<br/> |                                                                                                                                                                                                                                                                                                                                |
| `Type`                                                                                                                                                                                                                                                                                                                         | [Models.Components.Type](../../Models/Components/Type.md)                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                             | The type of the event.                                                                                                                                                                                                                                                                                                         |                                                                                                                                                                                                                                                                                                                                |