#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## ISortableRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware
[SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface ISortableRichEnumValueProvider<out TValue>
    where TValue : System.IComparable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>.Value') | The underlying value |
