### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SEnumBase<TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations. This type provides a hook to sort the .All collection.  
.Sort should be called only once and only once in the application startup.

```csharp
public abstract class SEnumBase<TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.EnumBase<TEnumeration, TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, System.IComparable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; SEnumBase<TEnumeration,TEnumeratedItem>

Derived  
&#8627; [SEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')

| Methods | |
| :--- | :--- |
| [Sort(IComparer&lt;TEnumeratedItem&gt;)](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.Sort(System.Collections.Generic.IComparer_TEnumeratedItem_).md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>.Sort(System.Collections.Generic.IComparer<TEnumeratedItem>)') | Sorts the .All collection. This should be called only once and only once in the application startup. |
