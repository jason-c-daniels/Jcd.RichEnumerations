#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Wrappers](Jcd.RichEnumerations.Wrappers.md 'Jcd.RichEnumerations.Wrappers')

## NamedAndDescribedRichEnum<TEnum> Class

A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type.

```csharp
public abstract class NamedAndDescribedRichEnum<TEnum> : Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum&lt;](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TEnum>

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedRichEnum(int, string, string)](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.NamedAndDescribedRichEnum(int,string,string).md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>.NamedAndDescribedRichEnum(int, string, string)') | A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type. |
