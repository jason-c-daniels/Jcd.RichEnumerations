#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## IRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface IRichEnumValueProvider<out TValue>
    where TValue : System.IEquatable<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.IRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')

| Properties                                                                                                                                        |                      |
|:--------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------|
| [Value](Jcd.RichEnumerations.Records.IRichEnumValueProvider_TValue_.Value.md 'Jcd.RichEnumerations.Records.IRichEnumValueProvider<TValue>.Value') | The underlying value |
