### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## DescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') with a Description property.

```csharp
public abstract class DescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.DescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property

<a name='Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableDEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') &#129106; DescribedSortableRichEnum<TValue,TEnum>

Derived  
&#8627; [DescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DescribedSortableRichEnum(TValue, string)](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.DescribedSortableRichEnum(TValue,string).md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.DescribedSortableRichEnum(TValue, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. |
