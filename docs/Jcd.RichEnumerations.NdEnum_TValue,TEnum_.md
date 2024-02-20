### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## NdEnum<TValue,TEnum> Class

A rich enumeration containing Description, Name and Value properties.

```csharp
public abstract class NdEnum<TValue,TEnum> : Jcd.RichEnumerations.Enum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.NdEnum<TValue, TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from NdEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.NdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; NdEnum<TValue,TEnum>

Derived  
&#8627; [NdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.NdEnum_TEnum_.md 'Jcd.RichEnumerations.NdEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [NdEnum(TValue, string, string)](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.NdEnum(TValue,string,string).md 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.NdEnum(TValue, string, string)') | A rich enumeration containing Description, Name and Value properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.Description') | The description for the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.NdEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.NdEnum<TValue,TEnum>.Name') | The name for the instance. This should be unique. |
