## Jcd.RichEnumerations Namespace

Provides TODO: A description of what this namespace provides.

| Classes | |
| :--- | :--- |
| [DEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DEnum_TEnum_.md 'Jcd.RichEnumerations.DEnum<TEnum>') | A rich Enum with a Description property. |
| [DEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>') | A rich Enum with a Description property. |
| [Enum&lt;TEnum&gt;](Jcd.RichEnumerations.Enum_TEnum_.md 'Jcd.RichEnumerations.Enum<TEnum>') | A rich Enum with .Value as an int. |
| [Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') | A rich Enum with .Value as a user provided type. |
| [EnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') | The base implementation of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum'). It provides<br/>access to all instances on the enumeration container by way of the .All property. |
| [EnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') | The base implementation of [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum'). It provides<br/>access to all instances on the enumeration container by way of the .All property.<br/>And allows lookup of items by value. This is used in [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum') to provide conversion operators. |
| [NdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NdEnum_TEnum_.md 'Jcd.RichEnumerations.NdEnum<TEnum>') | A rich enumeration containing Description, Name and Value properties with int as the underlying Value data type. |
| [NdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>') | A rich enumeration containing Description, Name and Value properties. |
| [NEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NEnum_TEnum_.md 'Jcd.RichEnumerations.NEnum<TEnum>') | A rich enumeration containing Name and Value properties with int as the underlying Value data type. |
| [NEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>') | A rich enumeration containing Name and Value properties. |
| [SdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SdEnum_TEnum_.md 'Jcd.RichEnumerations.SdEnum<TEnum>') | A rich Enum with a Description property. |
| [SdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>') | A rich Enum with a Description property. |
| [SEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SEnum_TEnum_.md 'Jcd.RichEnumerations.SEnum<TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') | A rich enum that can be sorted with a call to .Sort. |
| [SEnumBase&lt;TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations. This type provides a hook to sort the .All collection.<br/>.Sort should be called only once and only once in the application startup. |
| [SEnumBase&lt;TValue,TEnumeration,TEnumeratedItem&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') | A base for sortable rich enumerations where the .Value property is present on the enumerated type.<br/>This type provides a hook to sort the .All collection. .Sort should be called only once and only once in the application startup. |
| [SNdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SNdEnum_TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TEnum>') | A rich Enum with Name and Description properties. The type of the Value property is int. |
| [SNdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>') | A base rich Enum with Name and Description properties. |
| [SnEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SnEnum_TEnum_.md 'Jcd.RichEnumerations.SnEnum<TEnum>') | A rich Enum that's sortable with a Name property. |
| [SnEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>') | A rich Enum that's sortable with a Name property. |

| Interfaces | |
| :--- | :--- |
| [IEnumValueProvider&lt;TValue&gt;](Jcd.RichEnumerations.IEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>') | A helper interface to enable building auto casting into the data type aware Enum types. This helps minimize boilerplate code. |
