### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SnEnum<TEnum> Class

A rich Enum that's sortable with a Name property.

```csharp
public abstract class SnEnum<TEnum> : Jcd.RichEnumerations.SnEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.SnEnum<TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SnEnum_TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.SnEnum&lt;](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SnEnum_TEnum_.md#Jcd.RichEnumerations.SnEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>') &#129106; SnEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [SnEnum(int, string)](Jcd.RichEnumerations.SnEnum_TEnum_.SnEnum(int,string).md 'Jcd.RichEnumerations.SnEnum<TEnum>.SnEnum(int, string)') | A rich Enum that's sortable with a Name property. |
