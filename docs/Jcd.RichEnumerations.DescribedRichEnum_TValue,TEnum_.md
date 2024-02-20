### [Jcd.RichEnumerations](Jcd.RichEnumerations.md 'Jcd.RichEnumerations')

## DescribedRichEnum<TValue,TEnum> Class

A RichEnum with a Description property.

```csharp
public abstract class DescribedRichEnum<TValue,TEnum> : Jcd.RichEnumerations.RichEnum<TValue, TEnum>
    where TValue : System.IEquatable<TValue>
    where TEnum : Jcd.RichEnumerations.DescribedRichEnum<TValue, TEnum>, System.IComparable<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TValue'></a>

`TValue`

<a name='Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum'></a>

`TEnum`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnumBase&lt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TEnum')[,](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.RichEnum&lt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TValue](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TValue 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TValue')[,](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.md#Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.RichEnum<TValue,TEnum>') &#129106; DescribedRichEnum<TValue,TEnum>

Derived  
&#8627; [DescribedRichEnum&lt;TEnum&gt;](Jcd.RichEnumerations.DescribedRichEnum_TEnum_.md 'Jcd.RichEnumerations.DescribedRichEnum<TEnum>')

| Constructors | |
| :--- | :--- |
| [DescribedRichEnum(TValue, string)](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.DescribedRichEnum(TValue,string).md 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.DescribedRichEnum(TValue, string)') | A RichEnum with a Description property. |

| Properties | |
| :--- | :--- |
| [Description](Jcd.RichEnumerations.DescribedRichEnum_TValue,TEnum_.Description.md 'Jcd.RichEnumerations.DescribedRichEnum<TValue,TEnum>.Description') | The description for the instance. These should be unique. |
