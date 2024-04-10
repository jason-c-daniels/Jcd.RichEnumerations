#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')

## RichEnumBase(TValue) Constructor

Provides access to a lookup of all instances on the enumeration container by way of the [ByValue](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') property.
And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') to provide conversion
operators.

```csharp
protected RichEnumBase(TValue value);
```

#### Parameters

<a name='Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.RichEnumBase(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')

### Remarks

NOTE: This is intended as a supporting class. Consumers should prefer [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') or
[RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>') instead.