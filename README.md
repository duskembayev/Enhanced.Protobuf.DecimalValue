# Enhanced.Protobuf.DecimalValue

This is a simple library that allows you to use decimal values in your protobuf messages.

It implements the approach described in [ASP.NET documentation](https://learn.microsoft.com/en-us/aspnet/core/grpc/protobuf?view=aspnetcore-8.0#creating-a-custom-decimal-type-for-protobuf)

## Message definition

```protobuf
syntax = "proto3";

package enhanced.protobuf;

option csharp_namespace = "Enhanced.Protobuf";

message DecimalValue {
    int64 units = 1;
    sfixed32 nanos = 2;
}
```

## Features

- [x] Serialization and deserialization of decimal values.
- [x] Implicit conversion between `decimal` and `DecimalValue`.

## Installation

```bash
dotnet add package Enhanced.Protobuf.DecimalValue
```

## Usage

Define a message that uses `DecimalValue` type.

```protobuf
syntax = "proto3";

import "enhanced/protobuf/DecimalValue.proto";

message Product {
    string name = 1;
    enhanced.protobuf.DecimalValue price = 2;
}
```

Use the generated C# classes in your code.

```csharp
using Enhanced.Protobuf;

var product = new Product
{
    Name = "Apple",
    Price = 3.14m
};
```
