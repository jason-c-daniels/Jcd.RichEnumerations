#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnum<TValue,TEnum> Class

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
public abstract class SortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
System.IComparable<TEnum>,
System.IComparable<Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.SortableRichEnum<TValue, TEnum>, Jcd.RichEnumerations.Classes.ISortableRichEnumValueProvider<TValue>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnum<TValue,TEnum>

Derived
&#8627; [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>')
&#8627; [DescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedSortableRichEnum<TValue,TEnum>')
&#8627; [NamedAndDescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedSortableRichEnum<TValue,TEnum>')
&#8627; [NamedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedSortableRichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')

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

| Constructors                                                                                                                                                                                               |                                                                                                                                                                                                                                                                                                                           |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [SortableRichEnum(TValue)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.SortableRichEnum(TValue).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.SortableRichEnum(TValue)') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection. `.Sort()` should be called once and only once during application startup. |

| Methods                                                                                                                                                                   |                                                                                                                                                                                                                                                          |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [Equals(TEnum)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.Equals(TEnum).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instance to the target instance for equality. |

| Operators                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                        |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [operator ==(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_Equality(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')                        | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances for equality.                                                                              |
| [explicit operator SortableRichEnum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>(TValue)')                                                                                                                                                             | Explicit conversion from the underlying data type to an [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instance. This performs a lookup on the known values. |
| [explicit operator TValue(SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')                                                                                                                                                             | Explicit conversion to the underlying data type.                                                                                                                                                                                                                                       |
| [operator &gt;(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_GreaterThan(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_GreaterThan(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')                | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances to determine if the left hand side is greater than the right hand side.                |
| [operator &gt;=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_GreaterThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_GreaterThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)') | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances to determine if the left hand side is greater than or equal to the right hand side.    |
| [operator !=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_Inequality(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')                    | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances for inequality.                                                                            |
| [operator &lt;(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_LessThan(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_LessThan(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')                      | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances to determine if the left hand side is less than the right hand side.                   |
| [operator &lt;=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.op_LessThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>.op_LessThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>)')       | Compares two [SortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') instances to determine if the left hand side is less than or equal to the right hand side.       |