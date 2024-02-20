### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## DEnum<TEnum> Class

A rich Enum with a Description property.

```csharp
public abstract class DEnum<TEnum> : Jcd.RichEnumerations.DEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.DEnum<TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.DEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from DEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.DEnum&lt;](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.DEnum_TEnum_.md#Jcd.RichEnumerations.DEnum_TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>') &#129106; DEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [DEnum(int, string)](Jcd.RichEnumerations.DEnum_TEnum_.DEnum(int,string).md 'Jcd.RichEnumerations.DEnum<TEnum>.DEnum(int, string)') | A rich Enum with a Description property. |
