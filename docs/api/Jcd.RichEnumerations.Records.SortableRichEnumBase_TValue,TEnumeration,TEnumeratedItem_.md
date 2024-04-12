#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations where the .Value property is present on the enumerated type.
This type provides a hook to sort the .All collection. `.Sort()` should be called only once and only once in the
application startup.

```csharp
public class SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration, TEnumeratedItem>,
System.IEquatable<Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue, TEnumeration, TEnumeratedItem>>
    where TValue : System.IComparable<TValue>
    where TEnumeratedItem : System.IComparable<TEnumeratedItem>, Jcd.RichEnumerations.Records.ISortableRichEnumValueProvider<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue'></a>

`TValue`

The type of the .Value property on the TEnumeratedItem instances. This is used in the
conversion operators.

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>

Derived
&#8627; [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks

NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>') or
[SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>') instead.

| Properties                                                                                                                                                                                                    |                                                                                                            |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------|
| [ByValue](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') | A lookup of enumerated elements by their Value property. Useful for implementing conversion operators. |
