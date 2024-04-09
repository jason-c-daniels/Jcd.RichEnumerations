#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## IRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface IRichEnumValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>.Value') | The underlying value |
