#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedAndDescribedRichEnum<TValue,TEnum> Class

A rich enumeration containing Description, Name and Value properties.

```csharp
public class NamedAndDescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TValue](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedRichEnum&lt;TEnum&gt;](NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TEnum>')

| Constructors                                                                                                                                                                                                                                                   |                                                                       |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------|
| [NamedAndDescribedRichEnum(TValue, string, string)](NamedAndDescribedRichEnum_TValue,TEnum_..ctor.Eh2yB8ATQgMMwQfWtDKvPg.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.NamedAndDescribedRichEnum(TValue, string, string)') | A rich enumeration containing Description, Name and Value properties. |

| Properties                                                                                                                                                        |                                                          |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------|
| [Description](NamedAndDescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](NamedAndDescribedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Name')                      | The name for the instance. This should be unique.        |
