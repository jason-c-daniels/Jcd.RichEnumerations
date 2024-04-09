#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## RichEnumBase<TValue,TEnumeration,TEnumeratedItem> Class

Provides access to all instances on the enumeration container by way of the .All property.
And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') to provide conversion
operators.

```csharp
public abstract class RichEnumBase<TValue,TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration, TEnumeratedItem>,
System.IEquatable<Jcd.RichEnumerations.Records.RichEnumBase<TValue, TEnumeration, TEnumeratedItem>>
    where TValue : System.IEquatable<TValue>
    where TEnumeratedItem : Jcd.RichEnumerations.IRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue'></a>

`TValue`

The type of the .Value property on the TEnumeratedItem instances. This is used in the
conversion operators.

<a name='Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; RichEnumBase<TValue,TEnumeration,TEnumeratedItem>

Derived
&#8627; [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') or
[RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TEnum>') instead.

| Properties | |
| :--- | :--- |
| [ByValue](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') | A lookup of enumerated elements by their Value property. Useful for implementing conversion operators. |
| [Value](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.Value.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.Value') | The underlying value. |
