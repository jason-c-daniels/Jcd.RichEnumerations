#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

## SortableRichEnumBase(TValue) Constructor

A base for sortable rich enumerations where the .Value property is present on the enumerated type.
This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the
application startup.

```csharp
protected SortableRichEnumBase(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.SortableRichEnumBase(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') or
[SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') instead.