### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')

## SEnumBase<TEnumeration,TEnumeratedItem>.Sort(IComparer<TEnumeratedItem>) Method

Sorts the .All collection. This should be called only once and only once in the application startup.

```csharp
public static void Sort(System.Collections.Generic.IComparer<TEnumeratedItem>? comparison=null);
```
#### Parameters

<a name='Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Collections.Generic.IComparer_TEnumeratedItem_).comparison'></a>

`comparison` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[TEnumeratedItem](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

An optional custom comparer