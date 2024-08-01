#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedRichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') containing Name and Value properties.

```csharp
public abstract class NamedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue, TEnum>, System.IEquatable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TValue](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; NamedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedRichEnum&lt;TEnum&gt;](NamedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedRichEnum(TValue, string)](NamedRichEnum_TValue,TEnum_..ctor.OqigQ+GvCpmkCnlZNGFCqg.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.NamedRichEnum(TValue, string)') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') containing Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Name](NamedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
