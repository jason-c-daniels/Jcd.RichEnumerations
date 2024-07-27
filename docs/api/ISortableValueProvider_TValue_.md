#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## ISortableValueProvider<TValue> Interface

A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`  
types. This helps minimize boilerplate code.

```csharp
public interface ISortableValueProvider<out TValue> :
Jcd.RichEnumerations.IValueProvider<TValue>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.ISortableValueProvider_TValue_.TValue'></a>

`TValue`

The type of the value

Derived  
&#8627; [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')  
&#8627; [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')  
&#8627; [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')  
&#8627; [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnumValue<TValue,TEnum>')

Implements [Jcd.RichEnumerations.IValueProvider&lt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')[TValue](ISortableValueProvider_TValue_.md#Jcd.RichEnumerations.ISortableValueProvider_TValue_.TValue 'Jcd.RichEnumerations.ISortableValueProvider<TValue>.TValue')[&gt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')