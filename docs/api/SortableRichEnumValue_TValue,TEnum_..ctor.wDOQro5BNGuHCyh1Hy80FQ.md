#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')

## SortableRichEnumValue(TValue) Constructor

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
public SortableRichEnumValue(TValue value);
```

#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.SortableRichEnumValue(TValue).value'></a>

`value` [TValue](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TValue')

The value of the instance. This must be unique.

### Example

```csharp
public class MySortableRichEnum(float value, string customText) : SortableRichEnumValue<float,MySortableRichEnum>(value)
{
     public static readonly MySortableRichEnum Item1 = new (0.1f, "First Item");
     public static readonly MySortableRichEnum Item2 = new (-0.1f, "Second Item");

     public string CustomText => customText;
}

class Program
{
   public void Main()
   {
      // Call Sort() during app startup.

      // This sorts numerically, ascending.
      MySortableRichEnum.Sort();

      // This sorts numerically, descending.
      MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
   }
}
```