#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records').[SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')

## SortableDomainValue(TValue) Constructor

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>') is an open set of values which may  
share an underlying integral data type with others, but need semantic separation,  
such as database row identifier columns. Using these prevents accidentally using  
one in place of another.

```csharp
protected SortableDomainValue(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_.SortableDomainValue(TValue).value'></a>

`value` [TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>.TValue')