#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Wrappers](Jcd.RichEnumerations.Wrappers.md 'Jcd.RichEnumerations.Wrappers')

## NamedAndDescribedRichEnum<TValue,TEnum> Class

A rich enumeration containing Description, Name and Value properties.

```csharp
public abstract class NamedAndDescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedRichEnum(TValue, string, string)](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.NamedAndDescribedRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.NamedAndDescribedRichEnum(TValue, string, string)') | A rich enumeration containing Description, Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
