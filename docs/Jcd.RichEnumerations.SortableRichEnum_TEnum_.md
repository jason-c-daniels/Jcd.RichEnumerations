#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SortableRichEnum<TEnum> Class

A rich enum that can be sorted with a call to .Sort.

```csharp
public abstract class SortableRichEnum<TEnum> : Jcd.RichEnumerations.SortableRichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.SortableRichEnum<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>') &#129106; SortableRichEnum<TEnum>

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

| Constructors | |
| :--- | :--- |
| [SortableRichEnum(int)](Jcd.RichEnumerations.SortableRichEnum_TEnum_.SortableRichEnum(int).md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>.SortableRichEnum(int)') | A rich enum that can be sorted with a call to .Sort. |
