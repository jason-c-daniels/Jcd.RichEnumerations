#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedAndDescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')  with Name and Description properties.

```csharp
public abstract class NamedAndDescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>, Jcd.RichEnumerations.ISortableValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the value property.

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TValue](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedSortableRichEnum&lt;TEnum&gt;](NamedAndDescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedSortableRichEnum(TValue, string, string)](NamedAndDescribedSortableRichEnum_TValue,TEnum_..ctor.m31qtvKuzC3FcPyB5yCKOA.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.NamedAndDescribedSortableRichEnum(TValue, string, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')  with Name and Description properties. |

| Properties | |
| :--- | :--- |
| [Description](NamedAndDescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. This should be unique. |
| [Name](NamedAndDescribedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |

| Methods                                                                                                                                                                        |                                                      |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------|
| [ToString()](NamedAndDescribedSortableRichEnum_TValue,TEnum_.ToString().md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.ToString()') | Returns a string that represents the current object. |
