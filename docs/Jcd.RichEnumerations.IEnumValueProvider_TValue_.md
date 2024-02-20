### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## IEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware Enum types. This helps minimize boilerplate code.

```csharp
public interface IEnumValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.IEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived  
&#8627; [Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')  
&#8627; [SEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.IEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>.Value') | The underlying value |
