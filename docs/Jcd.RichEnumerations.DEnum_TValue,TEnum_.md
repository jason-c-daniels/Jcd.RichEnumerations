### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## DEnum<TValue,TEnum> Class

A rich Enum with a Description property.

```csharp
public abstract class DEnum<TValue,TEnum> : Jcd.RichEnumerations.Enum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.DEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.DEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Enum&lt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.DEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Enum_TValue,TEnum_.md 'Jcd.RichEnumerations.Enum<TValue,TEnum>') &#129106; DEnum<TValue,TEnum>

Derived  
&#8627; [DEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DEnum_TEnum_.md 'Jcd.RichEnumerations.DEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DEnum(TValue, string)](Jcd.RichEnumerations.DEnum_TValue,TEnum_.DEnum(TValue,string).md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.DEnum(TValue, string)') | A rich Enum with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.DEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.DEnum<TValue,TEnum>.Description') | The description for the instance. These should be unique. |
