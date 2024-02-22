### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations. This type provides a hook to sort the .All collection.  
.Sort should be called only once and only once in the application startup.

```csharp
public abstract class SortableRichEnumBase<TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.RichEnumBase<TEnumeration, TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, System.IComparable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumBase<TEnumeration,TEnumeratedItem>

Derived  
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') or [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>') instead.

| Methods | |
| :--- | :--- |
| [Sort(IComparer&lt;TEnumeratedItem&gt;)](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Collections.Generic.IComparer_TEnumeratedItem_).md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(System.Collections.Generic.IComparer<TEnumeratedItem>)') | Sorts the .All collection. This should be called only once and only once in the application startup. |
