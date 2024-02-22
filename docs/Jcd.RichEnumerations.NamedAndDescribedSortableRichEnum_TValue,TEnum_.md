### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## NamedAndDescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')  with Name and Description properties.

```csharp
public abstract class NamedAndDescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the value property.

<a name='Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedSortableRichEnum<TValue,TEnum>

Derived  
&#8627; [NamedAndDescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedAndDescribedSortableRichEnum(TValue, string, string)](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.NamedAndDescribedSortableRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.NamedAndDescribedSortableRichEnum(TValue, string, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')  with Name and Description properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
