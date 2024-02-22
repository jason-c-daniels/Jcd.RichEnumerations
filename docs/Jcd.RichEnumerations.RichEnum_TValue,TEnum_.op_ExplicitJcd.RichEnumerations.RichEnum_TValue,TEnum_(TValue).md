### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')

## RichEnum<TValue,TEnum>.explicit operator RichEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.RichEnum<TValue,TEnum> explicit operator RichEnum<TValue,TEnum>(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.RichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.RichEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns
[Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')  
The instance of the [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>'), if it exists. Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If a value not present in the enum is provided.