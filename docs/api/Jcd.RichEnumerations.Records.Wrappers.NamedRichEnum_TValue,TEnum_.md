#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records.Wrappers](Jcd.RichEnumerations.Records.Wrappers.md 'Jcd.RichEnumerations.Records.Wrappers')

## NamedRichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') containing Name and Value properties.

```csharp
public class NamedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Records.RichEnum<TValue, TEnum>,
System.IEquatable<Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue, TEnum>, System.IEquatable<TEnum>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnum&lt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') &#129106; NamedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum&lt;](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors                                                                                                                                                                                                                         |                                                                                                                                                                                             |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedRichEnum(TValue, string)](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.NamedRichEnum(TValue,string).md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.NamedRichEnum(TValue, string)') | Constructs a [NamedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>'). |

| Properties                                                                                                                                                 |                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------|
| [Name](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
