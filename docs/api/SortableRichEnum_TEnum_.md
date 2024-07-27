#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnum<TEnum> Class

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.
`.Sort()` should be called once and only once during application startup.

```csharp
public class SortableRichEnum<TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnum<int, TEnum>
    where TEnum : Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>, Jcd.RichEnumerations.ISortableValueProvider<int>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnum&lt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')[TEnum](SortableRichEnum_TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnum_TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.TEnum')[&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>') &#129106; SortableRichEnum<TEnum>

### Example

```csharp
public class MySortableRichEnum(int value, string customText) : SortableRichEnum<MySortableRichEnum>(value)
{
     public static readonly MySortableRichEnum Item1 = new (1, "First Item");
     public static readonly MySortableRichEnum Item2 = new (-1, "Second Item");

     public string CustomText => customText;
}

// ...
class Program
{
   public void Main()
   {
      // Call .Sort during app startup.

      // This sorts numerically, ascending.
      MySortableRichEnum.Sort();

      // This sorts numerically, descending.
      MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));
   }
}
```

| Constructors | |
| :--- | :--- |
| [SortableRichEnum(int)](SortableRichEnum_TEnum_..ctor.l6ECG3pmmfaosVo7rYOscA.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TEnum>.SortableRichEnum(int)') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection. `.Sort()` should be called once and only once during application startup. |
