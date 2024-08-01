#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableDomainValue<TValue,TType> Class

A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`
types. This helps minimize boilerplate code.

```csharp
public abstract class SortableDomainValue<TValue,TType> : Jcd.RichEnumerations.Classes.DomainValue<TValue, TType>,
Jcd.RichEnumerations.ISortableValueProvider<TValue>,
Jcd.RichEnumerations.IValueProvider<TValue>,
System.IComparable<TType>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TType : Jcd.RichEnumerations.Classes.SortableDomainValue<TValue, TType>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TValue'></a>

`TValue`

The type of the value

<a name='Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TType'></a>

`TType`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.DomainValue&lt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TValue')[,](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[TType](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TType 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TType')[&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') &#129106; SortableDomainValue<TValue,TType>

Derived
&#8627; [SortableDomainValue&lt;TType&gt;](SortableDomainValue_TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TType>')

Implements [Jcd.RichEnumerations.ISortableValueProvider&lt;](ISortableValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableValueProvider<TValue>')[TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TValue')[&gt;](ISortableValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableValueProvider<TValue>'), [Jcd.RichEnumerations.IValueProvider&lt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')[TValue](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TValue')[&gt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TType](SortableDomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TValue,TType_.TType 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.TType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')

| Constructors | |
| :--- | :--- |
| [SortableDomainValue(TValue)](SortableDomainValue_TValue,TType_..ctor.pUFqUCCA15vmi6oa/raZ8Q.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.SortableDomainValue(TValue)') | A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may share an underlying integral data type with others, but need semantic separation, such as database row identifier columns. Using these prevents accidentally using one in place of another. |

| Operators | |
| :--- | :--- |
| [operator ==(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_Equality.vrcscgcmgjqnCLkEsPLCng.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_Equality(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances for equality. |
| [operator &gt;(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_GreaterThan.GhYMM6JgjLpc//p0daQDRg.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_GreaterThan(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances to determine if the left hand side is greater than the right hand side. |
| [operator &gt;=(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_GreaterThanOrEqual.bBC3oVjUGwNdWGxWTEYavw.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_GreaterThanOrEqual(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances to determine if the left hand side is greater than or equal to the right hand side. |
| [operator !=(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_Inequality.5SsXE7jwT7gRkhrKyZ1ZHw.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_Inequality(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances for inequality. |
| [operator &lt;(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_LessThan.JlhqIl2OxG6NphUWrFtshA.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_LessThan(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances to determine if the left hand side is less than the right hand side. |
| [operator &lt;=(SortableDomainValue&lt;TValue,TType&gt;, SortableDomainValue&lt;TValue,TType&gt;)](SortableDomainValue_TValue,TType_.op_LessThanOrEqual.P0bw3EsrrKulEx8CziXplA.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>.op_LessThanOrEqual(Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>)') | Compares two [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') instances to determine if the left hand side is less than or equal to the right hand side. |
