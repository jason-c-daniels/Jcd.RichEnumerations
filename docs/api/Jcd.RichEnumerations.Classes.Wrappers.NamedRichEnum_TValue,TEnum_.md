#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedRichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') containing Name and Value properties.

```csharp
public class NamedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnum<TValue, TEnum>
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

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; NamedRichEnum<TValue,TEnum>

Derived
&#8627; [NamedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedRichEnum(TValue, string)](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.NamedRichEnum(TValue,string).md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.NamedRichEnum(TValue, string)') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') containing Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Name](Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
