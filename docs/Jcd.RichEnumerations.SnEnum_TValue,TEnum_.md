### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## SnEnum<TValue,TEnum> Class

A rich Enum that's sortable with a Name property.

```csharp
public abstract class SnEnum<TValue,TEnum> : Jcd.RichEnumerations.SEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.SnEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.EnumBase&lt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.EnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.EnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnumBase&lt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.SEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.SEnum&lt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.md#Jcd.RichEnumerations.SnEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.SEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.SEnum<TValue,TEnum>') &#129106; SnEnum<TValue,TEnum>

Derived  
&#8627; [SnEnum&lt;TEnum&gt;](Jcd.RichEnumerations.SnEnum_TEnum_.md 'Jcd.RichEnumerations.SnEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [SnEnum(TValue, string)](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.SnEnum(TValue,string).md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.SnEnum(TValue, string)') | A rich Enum that's sortable with a Name property. |

| Properties | |
| :--- | :--- |
| [Name](Jcd.RichEnumerations.SnEnum_TValue,TEnum_.Name.md 'Jcd.RichEnumerations.SnEnum<TValue,TEnum>.Name') | The name of the instance. This should be unique. |
