### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## Enum<TValue,TEnum> Class

A rich Enum with .Value as a user provided type.

```csharp
public abstract class Enum<TValue,TEnum> : Jcd.RichEnumerations.EnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
Jcd.RichEnumerations.IEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Enum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Enum_TValue,TEnum_.TValue'></a>

`TValue`

The data type for .Value

<a name='Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; Enum<TValue,TEnum>

Derived  
&#8627; [DEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>')  
&#8627; [Enum&lt;TEnum&gt;](Jcd.RichEnumerations.Enum_TEnum_.md 'Jcd.RichEnumerations.Enum<TEnum>')  
&#8627; [NdEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>')  
&#8627; [NEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.IEnumValueProvider&lt;](Jcd.RichEnumerations.IEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.Enum_TValue,TEnum_.md#Jcd.RichEnumerations.Enum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Enum<TValue,TEnum>.TValue')[&gt;](Jcd.RichEnumerations.IEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.IEnumValueProvider<TValue>')

| Constructors | |
| :--- | :--- |
| [Enum(TValue)](Jcd.RichEnumerations.Enum_TValue,TEnum_.Enum(TValue).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.Enum(TValue)') | A rich Enum with .Value as a user provided type. |

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.Enum_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.Value') | The underlying value. |

| Methods | |
| :--- | :--- |
| [Equals(TEnum)](Jcd.RichEnumerations.Enum_TValue,TEnum_.Equals(TEnum).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current Enum instance to the target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(Enum&lt;TValue,TEnum&gt;, Enum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Enum_TValue,TEnum_.op_Equality(Jcd.RichEnumerations.Enum_TValue,TEnum_,Jcd.RichEnumerations.Enum_TValue,TEnum_).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.Enum<TValue,TEnum>, Jcd.RichEnumerations.Enum<TValue,TEnum>)') | Compares two Enum instances for equality. |
| [explicit operator Enum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.Enum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Enum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.Enum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an Enum instance. This performs a lookup on the known values. |
| [explicit operator TValue(Enum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Enum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.Enum_TValue,TEnum_).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.Enum<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
| [operator !=(Enum&lt;TValue,TEnum&gt;, Enum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Enum_TValue,TEnum_.op_Inequality(Jcd.RichEnumerations.Enum_TValue,TEnum_,Jcd.RichEnumerations.Enum_TValue,TEnum_).md 'Jcd.RichEnumerations.Enum<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.Enum<TValue,TEnum>, Jcd.RichEnumerations.Enum<TValue,TEnum>)') | Compares two Enum instances for inequality. |
