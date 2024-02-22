### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## RichEnumBase<TValue,TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the .All property.  
And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') to provide conversion operators.

```csharp
public abstract class RichEnumBase<TValue,TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.RichEnumBase<TEnumeration, TEnumeratedItem>
    where TValue : System.IEquatable<TValue>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, Jcd.RichEnumerations.IRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue'></a>

`TValue`

The type of the .Value property on the TEnumeratedItem instances. This is used in the conversion operators.

<a name='Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; RichEnumBase<TValue,TEnumeration,TEnumeratedItem>

Derived  
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') or [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.RichEnum_TEnum_.md 'Jcd.RichEnumerations.RichEnum<TEnum>') instead.

| Properties | |
| :--- | :--- |
| [ByValue](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') | A lookup of enumerated elements by their Value property.<br/>Useful for implementing conversion operators. |
