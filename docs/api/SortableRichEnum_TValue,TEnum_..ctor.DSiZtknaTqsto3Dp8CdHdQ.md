#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')

## SortableRichEnum(TValue) Constructor

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
protected SortableRichEnum(TValue value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.SortableRichEnum(TValue).value'></a>

`value` [TValue](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')

The value of the instance. This must be unique.

### Example

```csharp
public class MySortableRichEnum(float value, string customText) : SortableRichEnum<float,MySortableRichEnum>(value)
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