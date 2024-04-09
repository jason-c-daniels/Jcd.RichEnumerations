#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations. This type provides a hook to sort the .All collection.
.Sort should be called only once and only once in the application startup.

```csharp
public abstract class SortableRichEnumBase<TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration, TEnumeratedItem>,
System.IEquatable<Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration, TEnumeratedItem>>
    where TEnumeratedItem : System.IComparable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumBase<TEnumeration,TEnumeratedItem>

Derived
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')
or [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>') instead.

| Methods | |
| :--- | :--- |
| [Sort(Comparison&lt;TEnumeratedItem&gt;)](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Comparison_TEnumeratedItem_).md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(System.Comparison<TEnumeratedItem>)') | Sorts the .All collection. This should be called only once and only once in the application startup. |
