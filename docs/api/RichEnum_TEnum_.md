#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## RichEnum<TEnum> Class

A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int.

```csharp
public class RichEnum<TEnum> : Jcd.RichEnumerations.Classes.RichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.RichEnum<TEnum>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum'></a>

`TEnum`

The enumeration type. This will contain both the structure definition and the enumeration
entries as public static readonly fields.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[,](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.RichEnumValue&lt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](RichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.RichEnum&lt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')[TEnum](RichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.RichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.TEnum')[&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') &#129106; RichEnum<TEnum>

### Example

```csharp
public class MyRichEnum(int value, string customText) : RichEnum<MyRichEnum>(value)
{
     public static readonly MyRichEnum Item1 = new (1, "First Item");
     public static readonly MyRichEnum Item2 = new (2, "Second Item");

     public string CustomText => customText;
}
```

| Constructors                                                                                                                  |                                                                                                                                           |
|:------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------|
| [RichEnum(int)](RichEnum_TEnum_..ctor.ZihynI5lRjZ0fle9W6jCRA.md 'Jcd.RichEnumerations.Classes.RichEnum<TEnum>.RichEnum(int)') | A [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>') with TValue set to int. |
