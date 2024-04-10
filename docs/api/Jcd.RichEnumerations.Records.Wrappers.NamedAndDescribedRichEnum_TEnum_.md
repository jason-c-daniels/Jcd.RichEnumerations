#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records.Wrappers](Jcd.RichEnumerations.Records.Wrappers.md 'Jcd.RichEnumerations.Records.Wrappers')

## NamedAndDescribedRichEnum<TEnum> Class

A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type.

```csharp
public abstract class NamedAndDescribedRichEnum<TEnum> : Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<int, TEnum>,
System.IEquatable<Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>>
    where TEnum : Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnum&lt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum&lt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TEnum>

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum&lt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors                                                                                                                                                                                                                                                                                     |                                                                                                                                                                                                            |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedAndDescribedRichEnum(int, string, string)](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.NamedAndDescribedRichEnum(int,string,string).md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>.NamedAndDescribedRichEnum(int, string, string)') | Constructs a [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>'). |