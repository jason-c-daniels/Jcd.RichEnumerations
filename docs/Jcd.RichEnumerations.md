#### [Jcd.RichEnumerations](index.md 'index')

## Jcd.RichEnumerations Namespace

Provides classes to simplify creating and using DDD-style Rich Enumerations.

| Classes | |
| :--- | :--- |
| [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.RichEnum_TEnum_.md 'Jcd.RichEnumerations.RichEnum<TEnum>') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') with TValue set to int. |
| [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') with .Value as a user provided type. |
| [RichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') | Provides access to all instances on the enumeration container by way of the .All property. |
| [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | Provides access to all instances on the enumeration container by way of the .All property. And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') to provide conversion operators. |
| [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations. This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. |
| [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations where the .Value property is present on the enumerated type. This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. |

| Interfaces | |
| :--- | :--- |
| [IRichEnumValueProvider&lt;TValue&gt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>') | A helper interface to enable building auto casting into the data type aware [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') types. This helps minimize boilerplate code. |
| [ISortableRichEnumValueProvider&lt;TValue&gt;](Jcd.RichEnumerations.ISortableRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableRichEnumValueProvider<TValue>') | A helper interface to enable building auto casting into the data type aware [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') types. This helps minimize boilerplate code. |
