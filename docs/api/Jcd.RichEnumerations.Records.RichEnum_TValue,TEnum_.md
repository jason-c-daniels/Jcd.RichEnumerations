#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Records](Jcd.RichEnumerations.Records.md 'Jcd.RichEnumerations.Records')

## RichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') with .Value as a user defined type.

```csharp
public class RichEnum<TValue,TEnum> : Jcd.RichEnumerations.Records.RichEnumBase<TValue, TEnum, TEnum>,
Jcd.RichEnumerations.Records.IRichEnumValueProvider<TValue>,
System.IEquatable<Jcd.RichEnumerations.Records.RichEnum<TValue, TEnum>>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Records.RichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The data type for .Value

<a name='Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Records.RichEnumBase&lt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Records.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; RichEnum<TValue,TEnum>

Derived
&#8627; [RichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TEnum>')
&#8627; [DescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.DescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.DescribedRichEnum<TValue,TEnum>')
&#8627; [NamedAndDescribedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')
&#8627; [NamedRichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.Wrappers.NamedRichEnum<TValue,TEnum>')

Implements [Jcd.RichEnumerations.Records.IRichEnumValueProvider&lt;](Jcd.RichEnumerations.Records.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Records.IRichEnumValueProvider<TValue>')[TValue](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TValue')[&gt;](Jcd.RichEnumerations.Records.IRichEnumValueProvider_TValue_.md 'Jcd.RichEnumerations.Records.IRichEnumValueProvider<TValue>'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.RichEnumerations.Records.RichEnum&lt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Properties | |
| :--- | :--- |
| [Value](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.Value') | The underlying value. |

| Operators | |
| :--- | :--- |
| [explicit operator RichEnum&lt;TValue,TEnum&gt;(TValue)](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.op_ExplicitJcd.RichEnumerations.Records.RichEnum_TValue,TEnum_(TValue).md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>') instance. This performs a lookup on the known values. |
| [explicit operator TValue(RichEnum&lt;TValue,TEnum&gt;)](Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_.op_ExplicitTValue(Jcd.RichEnumerations.Records.RichEnum_TValue,TEnum_).md 'Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.Records.RichEnum<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
