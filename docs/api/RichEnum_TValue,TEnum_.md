#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## RichEnum<TValue,TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with Value as a user defined type.

```csharp
public abstract class RichEnum<TValue,TEnum> : Jcd.RichEnumerations.Classes.RichEnumValue<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.RichEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue'></a>

`TValue`

The data type for .Value

<a name='Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TValue')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TValue](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TValue')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](RichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; RichEnum<TValue,TEnum>

Derived
&#8627; [RichEnum&lt;TEnum&gt;](RichEnum_TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>')
&#8627; [DescribedRichEnum&lt;TValue,TEnum&gt;](DescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.DescribedRichEnum<TValue,TEnum>')
&#8627; [NamedAndDescribedRichEnum&lt;TValue,TEnum&gt;](NamedAndDescribedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedAndDescribedRichEnum<TValue,TEnum>')
&#8627; [NamedRichEnum&lt;TValue,TEnum&gt;](NamedRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.Wrappers.NamedRichEnum<TValue,TEnum>')

### Example

```csharp
public class MyRichEnum(float value, string customText) : RichEnum<float,MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1.0f, "First Item");
     public static readonly MyRichEnum Item2 = new (2.1f, "Second Item");

     public string CustomText => customText;
}
```

| Constructors | |
| :--- | :--- |
| [RichEnum(TValue)](RichEnum_TValue,TEnum_..ctor.6BAIJGugMp0/up/vAE8psw.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.RichEnum(TValue)') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with Value as a user defined type. |

| Operators                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [explicit operator RichEnum&lt;TValue,TEnum&gt;(TValue)](RichEnum_TValue,TEnum_.op_Explicit.IFnKmSHAaFXJmvoFR/Uocw.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>.op_Explicit Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>(TValue)') | Explicit conversion from the underlying data type to an [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') instance. This performs a lookup on the known values. |
