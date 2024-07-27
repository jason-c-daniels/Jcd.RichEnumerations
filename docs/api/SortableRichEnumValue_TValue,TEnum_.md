#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableRichEnumValue<TValue,TEnum> Class

A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.  
`.Sort()` should be called once and only once during application startup.

```csharp
public abstract class SortableRichEnumValue<TValue,TEnum> : Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue, TEnum, TEnum>,
System.IEquatable<TEnum>,
System.IComparable<TEnum>,
System.IComparable<Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue, TEnum>>,
Jcd.RichEnumerations.ISortableValueProvider<TValue>,
Jcd.RichEnumerations.IValueProvider<TValue>
    where TValue : System.IEquatable<TValue>, System.IComparable<TValue>
    where TEnum : Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue, TEnum>, Jcd.RichEnumerations.ISortableValueProvider<TValue>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue'></a>

`TValue`

The type of the .Value property.

<a name='Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum'></a>

`TEnum`

The type deriving from SortableEnum{TEnum}

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.RichEnumBase&lt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[,](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](RichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.RichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TEnumeration,TEnumeratedItem>') &#129106; [Jcd.RichEnumerations.Classes.SortableRichEnumBase&lt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TValue](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TValue')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[,](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumBase_TValue,TEnumeration,TEnumeratedItem_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumBase<TValue,TEnumeration,TEnumeratedItem>') &#129106; SortableRichEnumValue<TValue,TEnum>

Derived  
&#8627; [SortableRichEnum&lt;TValue,TEnum&gt;](SortableRichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnum<TValue,TEnum>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.RichEnumerations.Classes.SortableRichEnumValue&lt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TValue](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TValue')[,](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[TEnum](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TEnum 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TEnum')[&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [Jcd.RichEnumerations.ISortableValueProvider&lt;](ISortableValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableValueProvider<TValue>')[TValue](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TValue')[&gt;](ISortableValueProvider_TValue_.md 'Jcd.RichEnumerations.ISortableValueProvider<TValue>'), [Jcd.RichEnumerations.IValueProvider&lt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')[TValue](SortableRichEnumValue_TValue,TEnum_.md#Jcd.RichEnumerations.Classes.SortableRichEnumValue_TValue,TEnum_.TValue 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.TValue')[&gt;](IValueProvider_TValue_.md 'Jcd.RichEnumerations.IValueProvider<TValue>')

### Example
  
```csharp  
public class MySortableRichEnum(float value, string customText) : SortableRichEnumValue<float,MySortableRichEnum>(value)  
{  
     public static readonly MySortableRichEnum Item1 = new (0.1f, "First Item");  
     public static readonly MySortableRichEnum Item2 = new (-0.1f, "Second Item");  
  
     public string CustomText => customText;  
}  
  
class Program  
{  
   public void Main()  
   {  
      // Call Sort() during app startup.  
  
      // This sorts numerically, ascending.  
      MySortableRichEnum.Sort();  
  
      // This sorts numerically, descending.  
      MySortableRichEnum.Sort((x,y) => y.Value.CompareTo(x.Value));  
   }  
}  
```

| Constructors | |
| :--- | :--- |
| [SortableRichEnumValue(TValue)](SortableRichEnumValue_TValue,TEnum_..ctor.wDOQro5BNGuHCyh1Hy80FQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.SortableRichEnumValue(TValue)') | A base for sortable rich enumerations. This type provides a hook to sort the [RichEnum&lt;TValue,TEnum&gt;](RichEnum_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.RichEnum<TValue,TEnum>')`.All` collection.<br/>`.Sort()` should be called once and only once during application startup. |

| Properties | |
| :--- | :--- |
| [Value](SortableRichEnumValue_TValue,TEnum_.Value.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.Value') | The underlying value |

| Methods | |
| :--- | :--- |
| [Equals(TEnum)](SortableRichEnumValue_TValue,TEnum_.Equals.ADEI5fDC8SpkDVWoKwf06Q.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.Equals(TEnum)') | Compares the Value of the current [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instance to the<br/>target instance for equality. |

| Operators | |
| :--- | :--- |
| [operator ==(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_Equality.gZqXM98A8IoOY+gE2GMtSQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_Equality(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances for equality. |
| [explicit operator TValue(SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_Explicit.6yH4QbngUt6KZL/mVxKxog.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_Explicit TValue(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Explicit conversion to the underlying data type. |
| [operator &gt;(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_GreaterThan.C8h/cowN3TlbFvr8xG0hPw.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_GreaterThan(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances to determine if the left hand side is greater<br/>than the right hand side. |
| [operator &gt;=(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_GreaterThanOrEqual.+yZiCufG5oCYVj7wsxsNCQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_GreaterThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances to determine if the left hand side is greater<br/>than or equal to the right hand side. |
| [operator !=(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_Inequality.y/cS9pzHd/krapUnJ6C2vQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_Inequality(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances for inequality. |
| [operator &lt;(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_LessThan.AcStKW2HutiUEBI7I8if0w.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_LessThan(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances to determine if the left hand side is less<br/>than<br/>the right hand side. |
| [operator &lt;=(SortableRichEnumValue&lt;TValue,TEnum&gt;, SortableRichEnumValue&lt;TValue,TEnum&gt;)](SortableRichEnumValue_TValue,TEnum_.op_LessThanOrEqual.PYXUfBFp2yFEm2x97l3RyQ.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>.op_LessThanOrEqual(Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>, Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>)') | Compares two [SortableRichEnumValue&lt;TValue,TEnum&gt;](SortableRichEnumValue_TValue,TEnum_.md 'Jcd.RichEnumerations.Classes.SortableRichEnumValue<TValue,TEnum>') instances to determine if the left hand side is less<br/>than<br/>or equal to the right hand side. |
