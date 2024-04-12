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

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TEnum>')

| Constructors                                                                                                                                                                                                                                                                                                            |                                                                       |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------|
| [NamedAndDescribedRichEnum(TValue, string, string)](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.NamedAndDescribedRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.NamedAndDescribedRichEnum(TValue, string, string)') | A rich enumeration containing Description, Name and Value properties. |

| Properties                                                                                                                                                                                              |                                                          |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------|
| [Description](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Name')                      | The name for the instance. This should be unique.        |
