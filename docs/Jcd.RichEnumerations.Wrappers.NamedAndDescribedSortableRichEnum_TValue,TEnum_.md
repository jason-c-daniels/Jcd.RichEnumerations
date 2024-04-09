#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Wrappers](Jcd.RichEnumerations.Wrappers.md 'Jcd.RichEnumerations.Wrappers')

## NamedAndDescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')  with Name and Description properties.

```csharp
public abstract class NamedAndDescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>, Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the value property.

<a name='Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedSortableRichEnum(TValue, string, string)](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.NamedAndDescribedSortableRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.NamedAndDescribedSortableRichEnum(TValue, string, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')  with Name and Description properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
