#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')

## RichEnum(TValue) Constructor

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with Value as a user defined type.

```csharp
public RichEnum(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.RichEnum(TValue).value'></a>

`value` [TValue](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TValue')

### Example

```csharp
public class MyRichEnum(float value, string customText) : RichEnum<float,MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1.0f, "First Item");
     public static readonly MyRichEnum Item2 = new (2.1f, "Second Item");

     public string CustomText => customText;
}
```