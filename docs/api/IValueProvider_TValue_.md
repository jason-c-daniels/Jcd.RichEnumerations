#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## IValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware `RichEnum{TValue,TEnum}`
types. This helps minimize boilerplate code.

```csharp
public interface IValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.IValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')
&#8627; [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')
&#8627; [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')
&#8627; [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')
&#8627; [ISortableValueProvider&lt;TValue&gt;](ISortableValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableValueProvider<TValue>')
&#8627; [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>')
&#8627; [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnumValue<TValue,TEnum>')
&#8627; [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')
&#8627; [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnumValue<TValue,TEnum>')

| Properties | |
| :--- | :--- |
| [Value](IValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.IValueProvider<TValue>.Value') | The underlying value |
