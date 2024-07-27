#### [Jcd.RichEnumerations](index.md 'index')

## Jcd.RichEnumerations.Classes Namespace

Provides plain old classes to simplify creating and using DDD-style Rich Enumerations.

### Example
  
```csharp  
public class MyRichEnum(int value, string customText) : RichEnum<MyRichEnum>(value)  
{  
     public static readonly MyRichEnum Item1 = new (1, "First Item");  
     public static readonly MyRichEnum Item2 = new (2, "Second Item");  
  
     public string CustomText => customText;  
}  
```

| Classes | |
| :--- | :--- |
| [DomainValue&lt;TType&gt;](DomainValue_TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TType>') | A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may<br/>share an underlying integral data type with others, but need semantic separation,<br/>such as database row identifier columns. Using these prevents accidentally using<br/>one in place of another. |
| [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') | A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may<br/>share an underlying integral data type with others, but need semantic separation,<br/>such as database row identifier columns. Using these prevents accidentally using<br/>one in place of another. |
| [FlagEnum&lt;TEnum&gt;](FlagEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>') | A rich enumeration type that supports setting individual flags for up to 64 flags. |
| [RichEnum&lt;TEnum&gt;](RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int. |
| [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with Value as a user defined type. |
| [RichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') | Provides access to all instances on the enumeration container by way of the [All](RichEnumBase_TEnumeration,TEnumeratedItem_.All.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>.All') property. |
| [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | Provides access to a lookup of all instances on the enumeration container by way of the [ByValue](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.ByValue.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>.ByValue')<br/>property.<br/>And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') to provide conversion<br/>operators. |
| [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') | A [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') with Value as a user defined type. |
| [SortableDomainValue&lt;TType&gt;](SortableDomainValue_TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TType>') | A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`<br/>types. This helps minimize boilerplate code. |
| [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') | A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`<br/>types. This helps minimize boilerplate code. |
| [SortableRichEnum&lt;TEnum&gt;](SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.<br/>`.Sort()` should be called once and only once during application startup. |
| [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.<br/>`.Sort()` should be called once and only once during application startup. |
| [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`All` collection.<br/>`.Sort()` should be called once and only once during application startup. |
| [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations where the .Value property is present on the enumerated type.<br/>This type provides a hook to sort the .All collection. `.Sort()` should be called once and only once during<br/>application startup. |
| [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.<br/>`.Sort()` should be called once and only once during application startup. |
