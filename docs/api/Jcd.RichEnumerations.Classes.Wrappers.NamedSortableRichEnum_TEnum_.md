#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes.Wrappers](Jcd.RichEnumerations.Classes.Wrappers.md 'Jcd.RichEnumerations.Classes.Wrappers')

## NamedSortableRichEnum<TEnum> Class

A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Name property.

```csharp
public abstract class NamedSortableRichEnum<TEnum> : Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>, Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<int>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNEnumeration

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum&lt;](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>') &#129106; NamedSortableRichEnum<TEnum>

| Constructors                                                                                                                                                                                                                                          |                                                                                                                                                                                              |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [NamedSortableRichEnum(int, string)](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TEnum_.NamedSortableRichEnum(int,string).md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TEnum>.NamedSortableRichEnum(int, string)') | A [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') with a Name property. |