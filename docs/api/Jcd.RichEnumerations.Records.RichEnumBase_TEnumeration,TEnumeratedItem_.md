#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## RichEnumBase<TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the [All](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>.All') property.

```csharp
public class RichEnumBase<TEnumeration,TEnumeratedItem> :
System.IEquatable<Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration, TEnumeratedItem>>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RichEnumBase<TEnumeration,TEnumeratedItem>

Derived
&#8627; [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')
&#8627; [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') or
[RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TEnum>') instead.

| Constructors | |
| :--- | :--- |
| [RichEnumBase()](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.RichEnumBase().md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>.RichEnumBase()') | |

| Properties | |
| :--- | :--- |
| [All](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>.All') | All enumerated elements. Populated in static constructor. |
