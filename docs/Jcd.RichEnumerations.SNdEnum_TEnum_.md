### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SNdEnum<TEnum> Class

A rich Enum with Name and Description properties. The type of the Value property is int.

```csharp
public abstract class SNdEnum<TEnum> : Jcd.RichEnumerations.SNdEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.SNdEnum<TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.SNdEnum&lt;](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SNdEnum_TEnum_.md#Jcd.RichEnumerations.SNdEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>') &#129106; SNdEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [SNdEnum(int, string, string)](Jcd.RichEnumerations.SNdEnum_TEnum_.SNdEnum(int,string,string).md 'Jcd.RichEnumerations.SNdEnum<TEnum>.SNdEnum(int, string, string)') | A rich Enum with Name and Description properties. The type of the Value property is int. |
