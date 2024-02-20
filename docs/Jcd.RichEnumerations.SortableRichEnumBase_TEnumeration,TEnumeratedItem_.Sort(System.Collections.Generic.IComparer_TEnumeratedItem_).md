### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

## SortableRichEnumBase<TEnumeration,TEnumeratedItem>.Sort(IComparer<TEnumeratedItem>) Method

Sorts the .All collection. This should be called only once and only once in the application startup.

```csharp
public static void Sort(System.Collections.Generic.IComparer<TEnumeratedItem>? comparison=null);
```
#### Parameters

<a name='Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Collections.Generic.IComparer_TEnumeratedItem_).comparison'></a>

`comparison` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[TEnumeratedItem](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

An optional custom comparer