### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## Enum<TEnum> Class

A rich Enum with .Value as an int.

```csharp
public abstract class Enum<TEnum> : Jcd.RichEnumerations.Enum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Enum<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Enum_TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TEnum_.md#Jcd.RichEnumerations.Enum_TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TEnum_.md#Jcd.RichEnumerations.Enum_TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TEnum_.md#Jcd.RichEnumerations.Enum_TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TEnum_.md#Jcd.RichEnumerations.Enum_TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Enum_TEnum_.md#Jcd.RichEnumerations.Enum_TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; Enum<TEnum>

| Constructors | |
| :--- | :--- |
| [Enum(int)](Jcd.RichEnumerations.Enum_TEnum_.Enum(int).md 'Jcd.RichEnumerations.Enum<TEnum>.Enum(int)') | A rich Enum with .Value as an int. |
