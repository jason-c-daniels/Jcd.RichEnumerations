### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## NEnum<TValue,TEnum> Class

A rich enumeration containing Name and Value properties.

```csharp
public abstract class NEnum<TValue,TEnum> : Jcd.RichEnumerations.Enum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.NEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.NEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; NEnum<TValue,TEnum>

Derived  
&#8627; [NEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NEnum_TEnum_.md 'Jcd.RichEnumerations.NEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NEnum(TValue, string)](Jcd.RichEnumerations.NEnum_TValue,TEnum_.NEnum(TValue,string).md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.NEnum(TValue, string)') | A rich enumeration containing Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Name](Jcd.RichEnumerations.NEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.NEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
