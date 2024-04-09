#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## ISortableRichEnumValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware
[SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')
types. This helps minimize boilerplate code.

```csharp
public interface ISortableRichEnumValueProvider<out TValue> :
Jcd.RichEnumerations.IRichEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived
&#8627; [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

Implements [Jcd.RichEnumerations.IRichEnumValueProvider&lt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.md#Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.TValue 'Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>.TValue')[&gt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>')