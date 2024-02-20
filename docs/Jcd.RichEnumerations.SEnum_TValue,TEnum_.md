### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SEnum<TValue,TEnum> Class

A rich enum that can be sorted with a call to .Sort.

```csharp
public abstract class SEnum<TValue,TEnum> : Jcd.RichEnumerations.SEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
Jcd.RichEnumerations.IEnumValueProvider<TValue>,
System.IComparable<TEnum>,
System.IComparable<Jcd.RichEnumerations.SEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.SEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; SEnum<TValue,TEnum>

Derived  
&#8627; [SdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>')  
&#8627; [SEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SEnum_TEnum_.md 'Jcd.RichEnumerations.SEnum<TEnum>')  
&#8627; [SNdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>')  
&#8627; [SnEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.IEnumValueProvider&lt;](Jcd.RichEnumerations.IEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TValue')[&gt;](Jcd.RichEnumerations.IEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')

| Constructors | |
| :--- | :--- |
| [SEnum(TValue)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.SEnum(TValue).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.SEnum(TValue)') | A rich enum that can be sorted with a call to .Sort. |

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.SEnum_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.Value') | The underlying value. |

| Methods | |
| :--- | :--- |
| [Equals(TEnum)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.Equals(TEnum).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current Enum instance to the target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_Equality(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two Enum instances for equality. |
| [explicit operator SEnum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.SEnum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.SEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values. |
| [explicit operator TValue(SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
| [operator &gt;(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_GreaterThan(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_GreaterThan(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is greater than the right hand side. |
| [operator &gt;=(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_GreaterThanOrEqual(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_GreaterThanOrEqual(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is greater than or equal to the right hand side. |
| [operator !=(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_Inequality(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two Enum instances for inequality. |
| [operator &lt;(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_LessThan(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_LessThan(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is less than the right hand side. |
| [operator &lt;=(SEnum&lt;TValue,TEnum&gt;, SEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.SEnum_TValue,TEnum_.op_LessThanOrEqual(Jcd.RichEnumerations.SEnum_TValue,TEnum_,Jcd.RichEnumerations.SEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>.op_LessThanOrEqual(Jcd.RichEnumerations.SEnum<TValue,TEnum>, Jcd.RichEnumerations.SEnum<TValue,TEnum>)') | Compares two SEnum instances to determine if the left hand side is less than or equal to the right hand side. |
