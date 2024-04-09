#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem> Class

A base for sortable rich enumerations where the .Value property is present on the enumerated type.
This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the
application startup.

```csharp
public abstract class SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem> : Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration, TEnumeratedItem>,
Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnumeratedItem : System.IEquatable<TEnumeratedItem>, System.IComparable<TEnumeratedItem>, Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue'></a>

`TValue`

The type of the .Value property on the TEnumeratedItem instances. This is used in the
conversion operators.

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration'></a>

`TEnumeration`

The type of the enumeration containing the enumerated items

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem'></a>

`TEnumeratedItem`

The type of the enumerated data.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeration](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeration 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeration')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnumeratedItem](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TEnumeratedItem 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TEnumeratedItem')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>

Derived
&#8627; [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')

Implements [Jcd.RichEnumerations.ISortableRichEnumValueProvider&lt;](Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md#Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.TValue')[&gt;](Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>')

### Remarks
NOTE: This is intended as a supporting class. Consumers should prefer [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') or
[SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') instead.

| Constructors | |
| :--- | :--- |
| [SortableRichEnumBase(TValue)](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.SortableRichEnumBase(TValue).md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.SortableRichEnumBase(TValue)') | A base for sortable rich enumerations where the .Value property is present on the enumerated type. This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. |

| Properties | |
| :--- | :--- |
| [ByValue](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue') | A lookup of enumerated elements by their Value property. Useful for implementing conversion operators. |
| [Value](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.Value.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>.Value') | The underlying value |
