#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')

## RichEnumValue(TValue) Constructor

A [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') with Value as a user defined type.

```csharp
public RichEnumValue(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.RichEnumValue(TValue).value'></a>

`value` [TValue](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TValue')

### Example

```csharp
public class MyRichEnum(float value, string customText) : RichEnum<float,MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1.0f, "First Item");
     public static readonly MyRichEnum Item2 = new (2.1f, "Second Item");

     public string CustomText => customText;
}
```