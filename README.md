# Jcd.RichEnumerations

A *netstandard2.0* library that provides DDD-style rich enumeration base classes.

## Examples

```csharp
// define the rich enum type.

using Jcd.RichEnumerations.Wrappers

// Derive from a simplifying wrapper. In this case one that already defines the description property.
public class MyRichEnum(int value, string description) : DescribedRichEnum<MyRichEnum>(value,description)
{
   public static readonly MyRichEnum Item1 = new(1, "Item 1");
   public static readonly MyRichEnum Item2 = new(2, "Item 2");
   public static readonly MyRichEnum Item3 = new(3, "Item 3");
}

// use the values
int userInput = GetUserInput();

// use the conversion operator to convert the raw number into an instance of the RichEnum.
var  ev = (MyRichEnum) userInput;

if (ev == MyRichEnum.Item1) {
   //.. do something specific to Item1 being selected.
}

```

## Badges

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.RichEnumerations)](https://github.com/jason-c-daniels/Jcd.RichEnumerations/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/https://ci.appveyor.com/project/jason-c-daniels/jcd-richenumerations)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.RichEnumerations)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.RichEnumerations)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.RichEnumerations?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.RichEnumerations)
[![Nuget](https://img.shields.io/nuget/v/Jcd.RichEnumerations?logo=nuget)](https://www.nuget.org/packages/Jcd.RichEnumerations)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.RichEnumerations/blob/main/docs/index.md)