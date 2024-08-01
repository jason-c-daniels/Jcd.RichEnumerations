#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')

## SortableDomainValue(TValue) Constructor

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may
share an underlying integral data type with others, but need semantic separation,
such as database row identifier columns. Using these prevents accidentally using
one in place of another.

```csharp
protected SortableDomainValue(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.SortableDomainValue(TValue).value'></a>

`value` [TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TValue')