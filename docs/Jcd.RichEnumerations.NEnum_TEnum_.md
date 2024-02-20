### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## NEnum<TEnum> Class

A rich enumeration containing Name and Value properties with int as the underlying Value data type.

```csharp
public abstract class NEnum<TEnum> : Jcd.RichEnumerations.NEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.NEnum<TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.NEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.NEnum&lt;](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NEnum_TEnum_.md#Jcd.RichEnumerations.NEnum_TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>') &#129106; NEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [NEnum(int, string)](Jcd.RichEnumerations.NEnum_TEnum_.NEnum(int,string).md 'Jcd.RichEnumerations.NEnum<TEnum>.NEnum(int, string)') | A rich enumeration containing Name and Value properties with int as the underlying Value data type. |
