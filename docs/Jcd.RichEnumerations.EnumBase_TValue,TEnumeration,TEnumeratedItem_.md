### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## EnumBase<TValue,TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the .All property.  
And allows lookup of items by value. This is used in [Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') to provide conversion operators.

```csharp
public abstract class EnumBase<TValue,TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.EnumBase<TEnumeration, TEnumeratedItem>
    where TValue : System.IEquatable<TValue>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, Jcd.RichEnumerations.IEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue'></a>

`TValue`

The type of the .Value property on the TEnumeratedItem instances. This is used in the conversion operators.

<a name='Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; EnumBase<TValue,TEnumeration,TEnumeratedItem>

Derived  
&#8627; [Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') or [Enum&lt;TEnum&gt;](Jcd.RichEnumerations.Enum_TEnum_.md 'Jcd.RichEnumerations.Enum<TEnum>') instead.

| Properties | |
| :--- | :--- |
| [ByValue](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') | A lookup of enumerated elements by their Value property.<br/>Useful for implementing conversion operators. |
