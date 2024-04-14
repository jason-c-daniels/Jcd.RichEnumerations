#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## ISortableRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware
[SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface ISortableRichEnumValueProvider<out TValue> :
Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')

Implements [Jcd.RichEnumerations.Classes.IRichEnumValueProvider&lt;](IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>')[TValue](ISortableRichEnumValueProvider_TValue_.md#Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider_TValue_.TValue 'Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<TValue>.TValue')[&gt;](IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>')