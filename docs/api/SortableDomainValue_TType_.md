#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## SortableDomainValue<TType> Class

A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`
types. This helps minimize boilerplate code.

```csharp
public abstract class SortableDomainValue<TType> : Jcd.RichEnumerations.Classes.SortableDomainValue<int, TType>
    where TType : Jcd.RichEnumerations.Classes.SortableDomainValue<TType>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.SortableDomainValue_TType_.TType'></a>

`TType`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.DomainValue&lt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[TType](SortableDomainValue_TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TType_.TType 'Jcd.RichEnumerations.Classes.SortableDomainValue<TType>.TType')[&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') &#129106; [Jcd.RichEnumerations.Classes.SortableDomainValue&lt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>')[TType](SortableDomainValue_TType_.md#Jcd.RichEnumerations.Classes.SortableDomainValue_TType_.TType 'Jcd.RichEnumerations.Classes.SortableDomainValue<TType>.TType')[&gt;](SortableDomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.SortableDomainValue<TValue,TType>') &#129106; SortableDomainValue<TType>