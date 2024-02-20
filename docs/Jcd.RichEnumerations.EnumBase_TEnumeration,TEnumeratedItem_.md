### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## EnumBase<TEnumeration,TEnumeratedItem> Class

The base implementation of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum'). It provides  
access to all instances on the enumeration container by way of the .All property.

```csharp
public abstract class EnumBase<TEnumeration,TEnumeratedItem>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>
```
#### Type parameters

<a name='Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumBase<TEnumeration,TEnumeratedItem>

Derived  
&#8627; [EnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')  
&#8627; [SEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') instead.

| Properties | |
| :--- | :--- |
| [All](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>.All') | All enumerated elements. Populated in static constructor. |
