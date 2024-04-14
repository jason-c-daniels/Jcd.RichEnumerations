#### [Jcd.RichEnumerations](index.md 'index')

### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## RichEnumValue<TValue,TEnum> Class

A [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') with Value as a user defined type.

```csharp
public class RichEnumValue<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.RichEnumValue<TValue, TEnum>
```

#### Type parameters

<a name='Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TValue'></a>

`TValue`

The data type for .Value

<a name='Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TValue')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; RichEnumValue<TValue,TEnum>

Derived
&#8627; [FlagEnum&lt;TEnum&gt;](FlagEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.FlagEnum<TEnum>')
&#8627; [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [Jcd.RichEnumerations.Classes.IRichEnumValueProvider&lt;](IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>')[TValue](RichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.TValue')[&gt;](IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Classes.IRichEnumValueProvider<TValue>')

### Example

```csharp
public class MyRichEnum(float value, string customText) : RichEnum<float,MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1.0f, "First Item");
     public static readonly MyRichEnum Item2 = new (2.1f, "Second Item");

     public string CustomText => customText;
}
```

| Constructors                                                                                                                                                          |                                                                                                                                                                     |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [RichEnumValue(TValue)](RichEnumValue_TValue,TEnum_..ctor.DsRqcckkj1hwxIngaH8vWw.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.RichEnumValue(TValue)') | A [RichEnumValue&lt;TValue,TEnum&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') with Value as a user defined type. |

| Properties                                                                                                     |                       |
|:---------------------------------------------------------------------------------------------------------------|:----------------------|
| [Value](RichEnumValue_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.Value') | The underlying value. |

| Methods                                                                                                                                                |                                                                                                                                                                                                     |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [Equals(TEnum)](RichEnumValue_TValue,TEnum_.Equals.FN+24sqSfwuOH7zHM+FGzg.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') instance to the target instance for equality. |

| Operators                                                                                                                                                                                                                                                                                                                                             |                                                                                                                                                        |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------|
| [operator ==(RichEnumValue&lt;TValue,TEnum&gt;, RichEnumValue&lt;TValue,TEnum&gt;)](RichEnumValue_TValue,TEnum_.op_Equality.zzvor8hQK2RMOH2Cs98i2g.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>)')     | Compares two [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') instances for equality.   |
| [explicit operator TValue(RichEnumValue&lt;TValue,TEnum&gt;)](RichEnumValue_TValue,TEnum_.op_Explicit.zW3H3/kMLqpvqDAZIHbVVg.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>)')                                                                              | Explicit conversion to the underlying data type.                                                                                                       |
| [operator !=(RichEnumValue&lt;TValue,TEnum&gt;, RichEnumValue&lt;TValue,TEnum&gt;)](RichEnumValue_TValue,TEnum_.op_Inequality.mLWVA5iB0w+BsyewWTZ0jA.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>)') | Compares two [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') instances for inequality. |
