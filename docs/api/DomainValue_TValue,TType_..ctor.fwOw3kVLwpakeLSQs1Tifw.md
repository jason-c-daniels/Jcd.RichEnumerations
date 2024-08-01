#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records').[DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>')

## DomainValue(TValue) Constructor

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>') is an open set of values which may
share an underlying integral data type with others, but need semantic separation,
such as database row identifier columns. Using these prevents accidentally using
one in place of another.

```csharp
protected DomainValue(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Records.DomainValue_TValue,TType_.DomainValue(TValue).value'></a>

`value` [TValue](DomainValue_TValue,TType_.md#Jcd.RichEnumerations.Records.DomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>.TValue')