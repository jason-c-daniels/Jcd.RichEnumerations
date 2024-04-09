#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Wrappers](Jcd.RichEnumerations.Wrappers.md 'Jcd.RichEnumerations.Wrappers')

## NamedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') with a Name property.

```csharp
public abstract class NamedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue, TEnum>, Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') &#129106; NamedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [NamedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedSortableRichEnum(TValue, string)](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.NamedSortableRichEnum(TValue,string).md 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.NamedSortableRichEnum(TValue, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') with a Name property. |

| Properties | |
| :--- | :--- |
| [Name](Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Wrappers.NamedSortableRichEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
