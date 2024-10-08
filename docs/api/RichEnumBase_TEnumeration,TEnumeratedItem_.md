#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## RichEnumBase<TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the [All](RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>.All') property.

```csharp
public abstract class RichEnumBase<TEnumeration,TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RichEnumBase<TEnumeration,TEnumeratedItem>

Derived
&#8627; [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')
&#8627; [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')

### Remarks

NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') or
[RichEnum&lt;TEnum&gt;](RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>') instead.

| Constructors | |
| :--- | :--- |
| [RichEnumBase()](RichEnumBase_TEnumeration,TEnumeratedItem_.RichEnumBase().md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>.RichEnumBase()') | Constructs an instance of the type. |

| Properties | |
| :--- | :--- |
| [All](RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>.All') | All enumerated elements. Populated on first call to [All](RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>.All'). |
