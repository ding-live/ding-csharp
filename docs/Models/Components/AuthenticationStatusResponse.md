# AuthenticationStatusResponse


## Fields

| Field                                                                                                                                                                                                                                                                                                                  | Type                                                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                                                |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CorrelationId`                                                                                                                                                                                                                                                                                                        | *string*                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | A unique, user-defined identifier that will be included in webhook events.                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                                        |
| `CreatedAt`                                                                                                                                                                                                                                                                                                            | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | N/A                                                                                                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                                                        |
| `Events`                                                                                                                                                                                                                                                                                                               | List<[Events](../../Models/Components/Events.md)>                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | Represents a collection of events that occur during the authentication process. Each event captures specific actions and outcomes related to the authentication attempts, checks, delivery statuses, and balance updates. The array can contain different types of events, each with its own structure and properties. |                                                                                                                                                                                                                                                                                                                        |
| `PhoneNumber`                                                                                                                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | An E.164 formatted phone number.                                                                                                                                                                                                                                                                                       | +1234567890                                                                                                                                                                                                                                                                                                            |
| `Signals`                                                                                                                                                                                                                                                                                                              | [Signals](../../Models/Components/Signals.md)                                                                                                                                                                                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | [Signals](/guides/prevent-fraud#signals) are data points used to distinguish between fraudulent and legitimate users.                                                                                                                                                                                                  |                                                                                                                                                                                                                                                                                                                        |
| `TemplateId`                                                                                                                                                                                                                                                                                                           | *string*                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | The template id associated with the message content variant to be sent.                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                        |
| `Uuid`                                                                                                                                                                                                                                                                                                                 | *string*                                                                                                                                                                                                                                                                                                               | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                     | The UUID of the corresponding authentication.                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                        |