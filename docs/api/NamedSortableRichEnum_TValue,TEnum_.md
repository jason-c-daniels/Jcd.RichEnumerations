#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Name property.

```csharp
public abstract class NamedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue, TEnum>, Jcd.RichEnumerations.ISortableValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TValue](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](NamedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; NamedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [NamedSortableRichEnum&lt;TEnum&gt;](NamedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NamedSortableRichEnum(TValue, string)](NamedSortableRichEnum_TValue,TEnum_..ctor.dtM+6NDaqgW/eyZC9peFMw.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.NamedSortableRichEnum(TValue, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Name property. |

| Properties | |
| :--- | :--- |
| [Name](NamedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
