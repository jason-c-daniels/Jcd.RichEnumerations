#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## FlagEnum<TEnum> Class

A rich enumeration type that supports setting individual flags for up to 64 flags.

```csharp
public abstract class FlagEnum<TEnum> : Jcd.RichEnumerations.Classes.RichEnumValue<ulong, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.FlagEnum<TEnum>, System.IEquatable<TEnum>, Jcd.RichEnumerations.IValueProvider<ulong>, new()
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum'></a>

`TEnum`

The flag type being defined.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](FlagEnum_TEnum_.md#Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](FlagEnum_TEnum_.md#Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](FlagEnum_TEnum_.md#Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](FlagEnum_TEnum_.md#Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](FlagEnum_TEnum_.md#Jcd.RichEnumerations.Classes.FlagEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; FlagEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [FlagEnum(ulong, string)](FlagEnum_TEnum_..ctor.0Y0EP1PZf/Tcrc/7hqGjlA.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.FlagEnum(ulong, string)') | Constructs a [FlagEnum&lt;TEnum&gt;](FlagEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>') instance. |

| Properties | |
| :--- | :--- |
| [IsBaseFlag](FlagEnum_TEnum_.IsBaseFlag.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.IsBaseFlag') | Indicates if this instance represents a value with a single bit set. |
| [IsSynthesized](FlagEnum_TEnum_.IsSynthesized.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.IsSynthesized') | Indicates if the instance was synthesized from the individual set bits. |
| [Name](FlagEnum_TEnum_.Name.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.Name') | The name of the flag instance. |

| Methods                                                                                                                                                      |                                                                              |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------|
| [IsValid(ulong)](FlagEnum_TEnum_.IsValid.qUYVl2ySSFHz/qsipsQXcA.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.IsValid(ulong)')                            | Determines if the passed in value can be converted into the enumerated type. |
| [SynthesizeName(ulong)](FlagEnum_TEnum_.SynthesizeName.TqJh0YeF2TizdJMs5fvqdw.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.SynthesizeName(ulong)')       | Creates the name for a synthesized instance.                                 |
| [SynthesizeResult(ulong)](FlagEnum_TEnum_.SynthesizeResult.tqUTg8phGJTEaWkxFGhU0g.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.SynthesizeResult(ulong)') | Creates a new instance of the derived type.                                  |
| [ToString()](FlagEnum_TEnum_.ToString().md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.ToString()')                                                        | Returns a string that represents the current object.                         |

| Operators | |
| :--- | :--- |
| [operator |(FlagEnum&lt;TEnum&gt;, FlagEnum&lt;TEnum&gt;)](FlagEnum_TEnum_.op_BitwiseOr.Dlqd4J8MygvxtzbqFJzXIg.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.op_BitwiseOr(Jcd.RichEnumerations.Classes.FlagEnum<TEnum>, Jcd.RichEnumerations.Classes.FlagEnum<TEnum>)') | Perform a bitwise OR on the operands and convert to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [operator |(FlagEnum&lt;TEnum&gt;, ulong)](FlagEnum_TEnum_.op_BitwiseOr.C/HI59YlDe4cYLrSXSDznQ.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.op_BitwiseOr(Jcd.RichEnumerations.Classes.FlagEnum<TEnum>, ulong)') | Perform a bitwise OR on the operands and convert to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [operator |(ulong, FlagEnum&lt;TEnum&gt;)](FlagEnum_TEnum_.op_BitwiseOr.tBC/we5LiQCVd0UVAjXTaA.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.op_BitwiseOr(ulong, Jcd.RichEnumerations.Classes.FlagEnum<TEnum>)') | Perform a bitwise OR on the operands and convert to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [explicit operator FlagEnum&lt;TEnum&gt;(ulong)](FlagEnum_TEnum_.op_Explicit.OHpGjsSkoqZg+hvrjtdCSw.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>.op_Explicit Jcd.RichEnumerations.Classes.FlagEnum<TEnum>(ulong)') | Converts a value to a [FlagEnum&lt;TEnum&gt;](FlagEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>') instance. |
