#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## IRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface IRichEnumValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.IRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [ISortableRichEnumValueProvider&lt;TValue&gt;](Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<TValue>')
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
&#8627; [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.Classes.IRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>.Value') | The underlying value |
