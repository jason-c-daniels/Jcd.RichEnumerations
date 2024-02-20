### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SdEnum<TEnum> Class

A rich Enum with a Description property.

```csharp
public abstract class SdEnum<TEnum> : Jcd.RichEnumerations.SdEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.SdEnum<TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SdEnum_TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableDEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.SdEnum&lt;](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SdEnum_TEnum_.md#Jcd.RichEnumerations.SdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>') &#129106; SdEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [SdEnum(int, string)](Jcd.RichEnumerations.SdEnum_TEnum_.SdEnum(int,string).md 'Jcd.RichEnumerations.SdEnum<TEnum>.SdEnum(int, string)') | A rich Enum with a Description property. |
