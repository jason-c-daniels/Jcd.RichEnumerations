#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedRichEnum<TEnum> Class

A [RichEnum&lt;TEnum&gt;](RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>') containing Name and Value properties with int as the underlying Value data type.

```csharp
public class NamedRichEnum<TEnum> : Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>, System.IEquatable<TEnum>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum&lt;](NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>')[TEnum](NamedRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.TEnum')[&gt;](NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>') &#129106; NamedRichEnum<TEnum>

| Constructors                                                                                                                                                               |                                                                                                                                                                               |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedRichEnum(int, string)](NamedRichEnum_TEnum_..ctor.m3l//Ll2x6KErg9614Bqzg.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>.NamedRichEnum(int, string)') | A [RichEnum&lt;TEnum&gt;](RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>') containing Name and Value properties with int as the underlying Value data type. |