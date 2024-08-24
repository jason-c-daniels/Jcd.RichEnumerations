#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnum<TValue,TEnum> Class

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')
`.All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
public abstract class SortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue, TEnum>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>, Jcd.RichEnumerations.ISortableValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TValue](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') &#129106; SortableRichEnum<TValue,TEnum>

Derived
&#8627; [SortableRichEnum&lt;TEnum&gt;](SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>')
&#8627; [DescribedSortableRichEnum&lt;TValue,TEnum&gt;](DescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>')
&#8627; [NamedAndDescribedSortableRichEnum&lt;TValue,TEnum&gt;](NamedAndDescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>')
&#8627; [NamedSortableRichEnum&lt;TValue,TEnum&gt;](NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>')

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

| Constructors                                                                                                                                                                      |                                                                                                                                                                                                                                                                                              |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [SortableRichEnum(TValue)](SortableRichEnum_TValue,TEnum_..ctor.DSiZtknaTqsto3Dp8CdHdQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.SortableRichEnum(TValue)') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection. `.Sort()` should be called once and only once during application startup. |

| Operators                                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [explicit operator SortableRichEnum&lt;TValue,TEnum&gt;(TValue)](SortableRichEnum_TValue,TEnum_.op_Explicit.h2n1/li9RKJiqDsSg9qS6A.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instance. This performs a lookup on the known values. |
