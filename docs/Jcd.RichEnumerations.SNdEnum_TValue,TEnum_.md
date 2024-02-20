### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SNdEnum<TValue,TEnum> Class

A base rich Enum with Name and Description properties.

```csharp
public abstract class SNdEnum<TValue,TEnum> : Jcd.RichEnumerations.SEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.SNdEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the value property.

<a name='Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableNdEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; SNdEnum<TValue,TEnum>

Derived  
&#8627; [SNdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SNdEnum_TEnum_.md 'Jcd.RichEnumerations.SNdEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [SNdEnum(TValue, string, string)](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.SNdEnum(TValue,string,string).md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.SNdEnum(TValue, string, string)') | A base rich Enum with Name and Description properties. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.Description') | The description of the instance. This should be unique. |
| [Name](Jcd.RichEnumerations.SNdEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.SNdEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
