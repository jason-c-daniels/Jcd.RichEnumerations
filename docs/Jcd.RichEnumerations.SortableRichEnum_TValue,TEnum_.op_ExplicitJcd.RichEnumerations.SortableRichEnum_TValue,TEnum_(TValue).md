### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')

## SortableRichEnum<TValue,TEnum>.explicit operator SortableRichEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum> explicit operator SortableRichEnum<TValue,TEnum>(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.SortableRichEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns
[Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')  
The instance of the Enum, if it exists. Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If a value not present in the enum is provided.