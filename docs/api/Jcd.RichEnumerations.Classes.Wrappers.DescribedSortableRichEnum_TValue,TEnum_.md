#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## DescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Description property.

```csharp
public class DescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>, Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property

<a name='Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableDEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; DescribedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [DescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DescribedSortableRichEnum(TValue, string)](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.DescribedSortableRichEnum(TValue,string).md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.DescribedSortableRichEnum(TValue, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. |
