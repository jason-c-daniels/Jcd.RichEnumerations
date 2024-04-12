#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## SortableRichEnum<TEnum> Class

A rich enum that can be sorted with a call to `.Sort()`.

```csharp
public class SortableRichEnum<TEnum> : Jcd.RichEnumerations.Records.SortableRichEnum<int, TEnum>,
System.IEquatable<Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>>
    where TEnum : Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>, Jcd.RichEnumerations.Records.ISortableRichEnumValueProvider<int>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.SortableRichEnum&lt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TValue,TEnum>') &#129106; SortableRichEnum<TEnum>

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.SortableRichEnum&lt;](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>')[TEnum](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.SortableRichEnum<TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

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