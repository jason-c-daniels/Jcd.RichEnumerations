#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
public class SortableRichEnumBase<TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration, TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, System.IComparable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumBase<TEnumeration,TEnumeratedItem>

Derived
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')
or [SortableRichEnum&lt;TEnum&gt;](SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') instead.

| Constructors | |
| :--- | :--- |
| [SortableRichEnumBase()](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.SortableRichEnumBase().md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.SortableRichEnumBase()') | Constructs an instance of the type. |

| Methods | |
| :--- | :--- |
| [Sort(Comparison&lt;TEnumeratedItem&gt;)](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort.TOzF27BY8iszV8hdMOLrmA.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(System.Comparison<TEnumeratedItem>)') | Sorts the .All collection. This should be called once and only once during application startup. |
