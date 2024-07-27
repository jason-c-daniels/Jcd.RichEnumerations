#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')

## SortableRichEnum<TValue,TEnum>.explicit operator SortableRichEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')
instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum> explicit operator SortableRichEnum<TValue,TEnum>(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns
[Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')
The instance of the [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>'), if it exists.
Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If a value not present in the enum is provided.