#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records.Wrappers](Jcd.RichEnumerations.Records.Wrappers.md 'Jcd.RichEnumerations.Records.Wrappers')

## NamedAndDescribedRichEnum<TValue,TEnum> Class

A rich enumeration containing Description, Name and Value properties.

```csharp
public class NamedAndDescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Records.RichEnum<TValue, TEnum>,
System.IEquatable<Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue, TEnum>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnum&lt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum&lt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors                                                                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedAndDescribedRichEnum(TValue, string, string)](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.NamedAndDescribedRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.NamedAndDescribedRichEnum(TValue, string, string)') | Constructs a [NamedAndDescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>') |

| Properties                                                                                                                                                                                              |                                                          |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------|
| [Description](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Name')                      | The name for the instance. This should be unique.        |
