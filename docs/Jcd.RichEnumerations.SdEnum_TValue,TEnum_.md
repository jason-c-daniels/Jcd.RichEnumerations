### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SdEnum<TValue,TEnum> Class

A rich Enum with a Description property.

```csharp
public abstract class SdEnum<TValue,TEnum> : Jcd.RichEnumerations.SEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.SdEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property

<a name='Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

The type being derived from SortableDEnum

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SdEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; SdEnum<TValue,TEnum>

Derived  
&#8627; [SdEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SdEnum_TEnum_.md 'Jcd.RichEnumerations.SdEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [SdEnum(TValue, string)](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.SdEnum(TValue,string).md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.SdEnum(TValue, string)') | A rich Enum with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.SdEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.SdEnum<TValue,TEnum>.Description') | The description of the instance. |
