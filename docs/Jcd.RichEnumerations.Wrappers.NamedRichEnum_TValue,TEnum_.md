#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Wrappers](Jcd.RichEnumerations.Wrappers.md 'Jcd.RichEnumerations.Wrappers')

## NamedRichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') containing Name and Value properties.

```csharp
public abstract class NamedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue, TEnum>, System.IEquatable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') &#129106; NamedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedRichEnum(TValue, string)](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.NamedRichEnum(TValue,string).md 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.NamedRichEnum(TValue, string)') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') containing Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Name](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
