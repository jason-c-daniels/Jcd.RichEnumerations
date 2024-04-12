#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>')

## RichEnum(int) Constructor

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int.

```csharp
public RichEnum(int value);
```

#### Parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TEnum_.RichEnum(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Example

```csharp
public class MyRichEnum(int value, string customText) : RichEnum<MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1, "First Item");
     public static readonly MyRichEnum Item2 = new (2, "Second Item");

     public string CustomText => customText;
}
```