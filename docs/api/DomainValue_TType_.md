#### [Jcd.RichEnumerations](index.md 'index')
### [Jcd.RichEnumerations.Classes](Jcd.RichEnumerations.Classes.md 'Jcd.RichEnumerations.Classes')

## DomainValue<TType> Class

A [DomainValue&lt;TValue,TType&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') is an open set of values which may  
share an underlying integral data type with others, but need semantic separation,  
such as database row identifier columns. Using these prevents accidentally using  
one in place of another.

```csharp
public abstract class DomainValue<TType> : Jcd.RichEnumerations.Classes.DomainValue<int, TType>
    where TType : Jcd.RichEnumerations.Classes.DomainValue<int, TType>
```
#### Type parameters

<a name='Jcd.RichEnumerations.Classes.DomainValue_TType_.TType'></a>

`TType`

The domain specific type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.RichEnumerations.Classes.DomainValue&lt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>')[TType](DomainValue_TType_.md#Jcd.RichEnumerations.Classes.DomainValue_TType_.TType 'Jcd.RichEnumerations.Classes.DomainValue<TType>.TType')[&gt;](DomainValue_TValue,TType_.md 'Jcd.RichEnumerations.Classes.DomainValue<TValue,TType>') &#129106; DomainValue<TType>