#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedAndDescribedSortableRichEnum<TValue,TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')  with Name and Description properties.

```csharp
public abstract class NamedAndDescribedSortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue, TEnum>, System.IComparable<TEnum>, Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the value property.

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; NamedAndDescribedSortableRichEnum<TValue,TEnum>

Derived
&#8627; [NamedAndDescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TEnum>')

| Constructors                                                                                                                                                                                                                                                                                                                                                    |                                                                                                                                                                                                               |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedAndDescribedSortableRichEnum(TValue, string, string)](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.NamedAndDescribedSortableRichEnum(TValue,string,string).md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.NamedAndDescribedSortableRichEnum(TValue, string, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')  with Name and Description properties. |

| Properties                                                                                                                                                                                                              |                                                         |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------|
| [Description](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Description') | The description of the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>.Name')                      | The name of the instance. This should be unique.        |