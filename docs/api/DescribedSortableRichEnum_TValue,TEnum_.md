#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## DescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Description property.

```csharp
public abstract class DescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>, Jcd.RichEnumerations.ISortableValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableDEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TValue](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; DescribedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [DescribedSortableRichEnum&lt;TEnum&gt;](DescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DescribedSortableRichEnum(TValue, string)](DescribedSortableRichEnum_TValue,TEnum_..ctor.cBIt+q5nKN0oQ+XkxOu7pg.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.DescribedSortableRichEnum(TValue, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](DescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. |
