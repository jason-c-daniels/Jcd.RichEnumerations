#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## RichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') with .Value as a user provided type.

```csharp
public abstract class RichEnum<TValue,TEnum> : Jcd.RichEnumerations.RichEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
Jcd.RichEnumerations.IRichEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.RichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The data type for .Value

<a name='Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; RichEnum<TValue,TEnum>

Derived
&#8627; [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.RichEnum_TEnum_.md 'Jcd.RichEnumerations.RichEnum<TEnum>')
&#8627; [DescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Wrappers.DescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.DescribedRichEnum<TValue,TEnum>')
&#8627; [NamedAndDescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')
&#8627; [NamedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Wrappers.NamedRichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.IRichEnumValueProvider&lt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.TValue')[&gt;](Jcd.RichEnumerations.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IRichEnumValueProvider<TValue>')

| Constructors | |
| :--- | :--- |
| [RichEnum(TValue)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.RichEnum(TValue).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.RichEnum(TValue)') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') with .Value as a user provided type. |

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.Value') | The underlying value. |

| Methods | |
| :--- | :--- |
| [Equals(TEnum)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.Equals(TEnum).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') instance to the target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(RichEnum&lt;TValue,TEnum&gt;, RichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.op_Equality(Jcd.RichEnumerations.RichEnum_TValue,TEnum_,Jcd.RichEnumerations.RichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.RichEnum<TValue,TEnum>, Jcd.RichEnumerations.RichEnum<TValue,TEnum>)') | Compares two [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') instances for equality. |
| [explicit operator RichEnum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.RichEnum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.RichEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') instance. This performs a lookup on the known values. |
| [explicit operator TValue(RichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.RichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.RichEnum<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
| [operator !=(RichEnum&lt;TValue,TEnum&gt;, RichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.op_Inequality(Jcd.RichEnumerations.RichEnum_TValue,TEnum_,Jcd.RichEnumerations.RichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.RichEnum<TValue,TEnum>, Jcd.RichEnumerations.RichEnum<TValue,TEnum>)') | Compares two [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') instances for inequality. |
