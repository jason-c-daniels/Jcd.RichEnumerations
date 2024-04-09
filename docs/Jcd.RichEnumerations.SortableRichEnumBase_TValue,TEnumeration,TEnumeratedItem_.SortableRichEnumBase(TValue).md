#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

## SortableRichEnumBase(TValue) Constructor

A base for sortable rich enumerations where the .Value property is present on the enumerated type.
This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the
application startup.

```csharp
protected SortableRichEnumBase(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.SortableRichEnumBase(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>') or
[SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>') instead.