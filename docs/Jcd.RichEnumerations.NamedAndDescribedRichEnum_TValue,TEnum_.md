### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## NamedAndDescribedRichEnum<TValue,TEnum> Class

A rich enumeration containing Description, Name and Value properties.

```csharp
public abstract class NamedAndDescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') &#129106; NamedAndDescribedRichEnum<TValue,TEnum>

Derived  
&#8627; [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedRichEnum(TValue, string, string)](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.NamedAndDescribedRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.NamedAndDescribedRichEnum(TValue, string, string)') | A rich enumeration containing Description, Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
