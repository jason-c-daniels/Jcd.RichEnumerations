#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records').[SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')

## SortableDomainValue<TValue,TType>.CompareTo(SortableDomainValue<TValue,TType>) Method

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.DomainValue<TValue,TType>') is an open set of values which may
share an underlying integral data type with others, but need semantic separation,
such as database row identifier columns. Using these prevents accidentally using
one in place of another.

```csharp
public int CompareTo(Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>? other);
```
#### Parameters

<a name='Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_.CompareTo(Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_).other'></a>

`other` [Jcd.RichEnumerations.Records.SortableDomainValue&lt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')[TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>.TValue')[,](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')[TType](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Records.SortableDomainValue_TValue,TType_.TType 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>.TType')[&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Records.SortableDomainValue<TValue,TType>')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')