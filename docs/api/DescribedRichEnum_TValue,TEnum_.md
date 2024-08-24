#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## DescribedRichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with a Description property.

```csharp
public abstract class DescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TValue](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TValue')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; DescribedRichEnum<TValue,TEnum>

Derived
&#8627; [DescribedRichEnum&lt;TEnum&gt;](DescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DescribedRichEnum(TValue, string)](DescribedRichEnum_TValue,TEnum_..ctor.C0d2c03K8xfyBZ4RJnweeg.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.DescribedRichEnum(TValue, string)') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](DescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. These should be unique. |

| Methods                                                                                                                                        |                                                      |
|:-----------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------|
| [ToString()](DescribedRichEnum_TValue,TEnum_.ToString().md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>.ToString()') | Returns a string that represents the current object. |
