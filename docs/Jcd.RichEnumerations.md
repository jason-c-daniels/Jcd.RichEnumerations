## Jcd.RichEnumerations Namespace

Provides TODO: A description of what this namespace provides.

| Classes | |
| :--- | :--- |
| [DescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.DescribedRichEnum<TEnum>') | A RichEnum with a Description property. |
| [DescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>') | A RichEnum with a Description property. |
| [DescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TEnum>') | A SortableRichEnum with a Description property. |
| [DescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>') | A SortableRichEnum with a Description property. |
| [NamedAndDescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TEnum>') | A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type. |
| [NamedAndDescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedRichEnum<TValue,TEnum>') | A rich enumeration containing Description, Name and Value properties. |
| [NamedAndDescribedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TEnum>') | A SortableRichEnum with Name and Description properties. The type of the Value property is int. |
| [NamedAndDescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>') | A SortableRichEnum with Name and Description properties. |
| [NamedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedRichEnum<TEnum>') | A RichEnum containing Name and Value properties with int as the underlying Value data type. |
| [NamedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedRichEnum<TValue,TEnum>') | A RichEnum containing Name and Value properties. |
| [NamedSortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NamedSortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.NamedSortableRichEnum<TEnum>') | A SortableRichEnum with a Name property. |
| [NamedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedSortableRichEnum<TValue,TEnum>') | A SortableRichEnum with a Name property. |
| [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.RichEnum_TEnum_.md 'Jcd.RichEnumerations.RichEnum<TEnum>') | A RichEnum with .Value as an int. |
| [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') | A RichEnum with .Value as a user provided type. |
| [RichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') | Provides access to all instances on the enumeration container by way of the .All property. |
| [RichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | Provides access to all instances on the enumeration container by way of the .All property.<br/>And allows lookup of items by value. This is used in [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') to provide conversion operators. |
| [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SortableRichEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations. This type provides a hook to sort the .All collection.<br/>.Sort should be called only once and only once in the application startup. |
| [SortableRichEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations where the .Value property is present on the enumerated type.<br/>This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. |

| Interfaces | |
| :--- | :--- |
| [IRichEnumValueProvider&lt;TValue&gt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>') | A helper interface to enable building auto casting into the data type aware Enum types. This helps minimize boilerplate code. |
