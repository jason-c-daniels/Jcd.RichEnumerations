### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[SEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')

## SEnum<TValue,TEnum>.explicit operator SEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.SEnum<TValue,TEnum> explicit operator SEnum<TValue,TEnum>(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.SEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns
[Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')  
The instance of the Enum, if it exists. Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If a value not present in the enum is provided.