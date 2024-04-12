#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## RichEnum<TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int.

```csharp
public class RichEnum<TEnum> : Jcd.RichEnumerations.Classes.RichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.RichEnum<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[,](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; RichEnum<TEnum>

### Example

```csharp
public class MyRichEnum(int value, string customText) : RichEnum<MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1, "First Item");
     public static readonly MyRichEnum Item2 = new (2, "Second Item");

     public string CustomText => customText;
}
```

| Constructors | |
| :--- | :--- |
| [RichEnum(int)](Jcd.RichEnumerations.Classes.RichEnum_TEnum_.RichEnum(int).md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.RichEnum(int)') | A [RichEnum&lt;TValue,TEnum&gt;](Jcd.RichEnumerations.Classes.RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int. |
