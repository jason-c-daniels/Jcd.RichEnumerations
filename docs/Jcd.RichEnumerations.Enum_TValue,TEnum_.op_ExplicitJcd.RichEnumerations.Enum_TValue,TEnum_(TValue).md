### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations').[Enum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')

## Enum<TValue,TEnum>.explicit operator Enum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.Enum<TValue,TEnum> explicit operator Enum<TValue,TEnum>(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Enum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Enum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TValue')

The value to convert.

#### Returns
[Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')  
The instance of the Enum, if it exists. Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If a value not present in the enum is provided.