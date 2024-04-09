#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes').[SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>')

## SortableRichEnum(int) Constructor

A rich enum that can be sorted with a call to .Sort.

```csharp
protected SortableRichEnum(int value);
```
#### Parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.SortableRichEnum(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value of the instance. This must be unique.

### Example

```csharp
public class MySortableRichEnum(int value, string customText) : SortableRichEnum<MySortableRichEnum>(value)
{
     public static readonly MySortableRichEnum Item1 = new (1, "First Item");
     public static readonly MySortableRichEnum Item2 = new (-1, "Second Item");

     public string CustomText => customText;
}

// ...
class Program
{
   public void Main()
   {
      // Call .Sort during app startup.

      // This sorts numerically, ascending.
      MySortableRichEnum.Sort();

      // This sorts numerically, descending.
      MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
   }
}
```