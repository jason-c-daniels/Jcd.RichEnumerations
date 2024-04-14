#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')

## RichEnum<TValue,TEnum>.explicit operator RichEnum<TValue,TEnum>(TValue) Operator

Explicit conversion from the underlying data type to an [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') instance. This
performs a lookup on the known values.

```csharp
public static Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum> explicit operator RichEnum<TValue,TEnum>(TValue value);
```

#### Parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_(TValue).value'></a>

`value` [TValue](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TValue')

The value to convert.

#### Returns

[Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TValue](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TValue')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
The instance of the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>'), if it exists. Throws an exception, otherwise.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If a value not present in the enum is provided.