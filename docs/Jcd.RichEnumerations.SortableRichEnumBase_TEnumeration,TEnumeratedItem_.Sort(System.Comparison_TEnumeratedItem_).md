#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(Comparison<TEnumeratedItem>) Method

Sorts the .All collection. This should be called only once and only once in the application startup.

```csharp
public static void Sort(System.Comparison<TEnumeratedItem>? comparison=null);
```
#### Parameters

<a name='Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Comparison_TEnumeratedItem_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[TEnumeratedItem](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

An optional custom comparer