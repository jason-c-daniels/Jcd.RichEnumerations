### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## RichEnumBase<TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the .All property.

```csharp
public abstract class RichEnumBase<TEnumeration,TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RichEnumBase<TEnumeration,TEnumeratedItem>

Derived  
&#8627; [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')  
&#8627; [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') or [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.RichEnum_TEnum_.md 'Jcd.RichEnumerations.RichEnum<TEnum>') instead.

| Properties | |
| :--- | :--- |
| [All](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>.All') | All enumerated elements. Populated in static constructor. |
