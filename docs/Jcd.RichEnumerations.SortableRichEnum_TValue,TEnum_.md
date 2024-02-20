### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SortableRichEnum<TValue,TEnum> Class

A rich enum that can be sorted with a call to .Sort.

```csharp
public abstract class SortableRichEnum<TValue,TEnum> : Jcd.RichEnumerations.SortableRichEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
Jcd.RichEnumerations.IRichEnumValueProvider<TValue>,
System.IComparable<TEnum>,
System.IComparable<Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.SortableRichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SortableRichEnumBase&lt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnum<TValue,TEnum>

Derived  
&#8627; [DescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.DescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DescribedSortableRichEnum<TValue,TEnum>')  
&#8627; [NamedAndDescribedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedAndDescribedSortableRichEnum<TValue,TEnum>')  
&#8627; [NamedSortableRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NamedSortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NamedSortableRichEnum<TValue,TEnum>')  
&#8627; [SortableRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SortableRichEnum_TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.IRichEnumValueProvider&lt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TValue')[&gt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.RichEnumerations.SortableRichEnum&lt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')

| Constructors | |
| :--- | :--- |
| [SortableRichEnum(TValue)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.SortableRichEnum(TValue).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.SortableRichEnum(TValue)') | A rich enum that can be sorted with a call to .Sort. |

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.Value') | The underlying value. |

| Methods | |
| :--- | :--- |
| [Equals(TEnum)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.Equals(TEnum).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current Enum instance to the target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_Equality(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two Enum instances for equality. |
| [explicit operator SortableRichEnum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.SortableRichEnum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values. |
| [explicit operator TValue(SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
| [operator &gt;(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_GreaterThan(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_GreaterThan(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is greater than the right hand side. |
| [operator &gt;=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_GreaterThanOrEqual(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_GreaterThanOrEqual(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is greater than or equal to the right hand side. |
| [operator !=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_Inequality(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two Enum instances for inequality. |
| [operator &lt;(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_LessThan(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_LessThan(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is less than the right hand side. |
| [operator &lt;=(SortableRichEnum&lt;TValue,TEnum&gt;, SortableRichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_.op_LessThanOrEqual(Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_,Jcd.RichEnumerations.SortableRichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>.op_LessThanOrEqual(Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>, Jcd.RichEnumerations.SortableRichEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is less than or equal to the right hand side. |
