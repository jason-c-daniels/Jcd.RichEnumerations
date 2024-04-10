#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## ISortableRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware
[SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface ISortableRichEnumValueProvider<out TValue>
    where TValue : System.IComparable<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.ISortableRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

| Properties                                                                                                                                                        |                      |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------|
| [Value](Jcd.RichEnumerations.Records.ISortableRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.Records.ISortableRichEnumValueProvider<TValue>.Value') | The underlying value |
