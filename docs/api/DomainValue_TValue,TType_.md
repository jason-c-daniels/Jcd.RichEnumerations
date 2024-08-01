#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## DomainValue<TValue,TType> Class

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may
share an underlying integral data type with others, but need semantic separation,
such as database row identifier columns. Using these prevents accidentally using
one in place of another.

```csharp
public abstract class DomainValue<TValue,TType> :
System.IEquatable<TType>,
Jcd.RichEnumerations.IValueProvider<TValue>
    where TValue : System.IEquatable<TValue>
    where TType : Jcd.RichEnumerations.Classes.DomainValue<TValue, TType>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.DomainValue_TValue,TType_.TValue'></a>

`TValue`

The data type for underlying value.

<a name='Jcd.RichEnumerations.Classes.DomainValue_TValue,TType_.TType'></a>

`TType`

The domain specific type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DomainValue<TValue,TType>

Derived
&#8627; [DomainValue&lt;TType&gt;](DomainValue_TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TType>')
&#8627; [SortableDomainValue&lt;TValue,TType&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TType](DomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.DomainValue_TValue,TType_.TType 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.TType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.IValueProvider&lt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')[TValue](DomainValue_TValue,TType_.md#Jcd.RichEnumerations.Classes.DomainValue_TValue,TType_.TValue 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.TValue')[&gt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')

| Constructors | |
| :--- | :--- |
| [DomainValue(TValue)](DomainValue_TValue,TType_..ctor.pdD4bGVOjqBWvmsG6jik6w.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.DomainValue(TValue)') | A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may share an underlying integral data type with others, but need semantic separation, such as database row identifier columns. Using these prevents accidentally using one in place of another. |

| Properties | |
| :--- | :--- |
| [Value](DomainValue_TValue,TType_.Value.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.Value') | The underlying value. |

| Methods | |
| :--- | :--- |
| [Equals(TType)](DomainValue_TValue,TType_.Equals.5RfNM7UGeXDCjRoptYHSlQ.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.Equals(TType)') | Compares the Value of the current [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') instance to the target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(DomainValue&lt;TValue,TType&gt;, DomainValue&lt;TValue,TType&gt;)](DomainValue_TValue,TType_.op_Equality.+DZQGZbrNxp0sre51l1P1A.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.op_Equality(Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>)') | Compares two [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') instances for equality. |
| [explicit operator TValue(DomainValue&lt;TValue,TType&gt;)](DomainValue_TValue,TType_.op_Explicit.VdDmc3l+wP0tG8vVTVTsCA.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.op_Explicit TValue(Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>)') | Explicit conversion to the underlying data type. |
| [operator !=(DomainValue&lt;TValue,TType&gt;, DomainValue&lt;TValue,TType&gt;)](DomainValue_TValue,TType_.op_Inequality.IwyJwLsTCBHPkWH784r/eQ.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>.op_Inequality(Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>, Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>)') | Compares two [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') instances for inequality. |
