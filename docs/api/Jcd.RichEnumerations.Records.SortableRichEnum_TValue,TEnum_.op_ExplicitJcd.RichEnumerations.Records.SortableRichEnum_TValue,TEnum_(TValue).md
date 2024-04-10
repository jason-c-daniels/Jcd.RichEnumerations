#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records').[SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')

## SortableRichEnum<TValue,TEnum>.explicit operator SortableRichEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')
instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum> explicit operator SortableRichEnum<TValue,TEnum>(TValue value);
```

#### Parameters

<a name='Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns

[Jcd.RichEnumerations.Records.SortableRichEnum&lt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')
The instance of the [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>'), if it exists.
Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If a value not present in the enum is provided.