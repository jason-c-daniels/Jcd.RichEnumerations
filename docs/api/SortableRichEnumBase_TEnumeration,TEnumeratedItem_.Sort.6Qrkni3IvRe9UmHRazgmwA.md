#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records').[SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(Comparison<TEnumeratedItem>) Method

Sorts the .All collection. This should be called once and only once during application startup.

```csharp
public static void Sort(System.Comparison<TEnumeratedItem>? comparison=null);
```

#### Parameters

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Comparison_TEnumeratedItem_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[TEnumeratedItem](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

An optional custom comparer