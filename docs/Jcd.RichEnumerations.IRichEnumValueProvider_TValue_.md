### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## IRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') types. This helps minimize boilerplate code.

```csharp
public interface IRichEnumValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived  
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')  
&#8627; [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>.Value') | The underlying value |
