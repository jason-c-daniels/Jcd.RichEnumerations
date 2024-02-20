namespace Jcd.RichEnumerations.Examples;

public class ExampleEnum1(int value, string name, string description) 
    : NdEnum<ExampleEnum1>(value,name,description)
{
    #region Enumerated items

    public static ExampleEnum1 Item2 = new(2, "ExampleEnum1.Item2", "The second item.");
    public static ExampleEnum1 Item1 = new(1, "ExampleEnum1.Item1", "The first item.");
    public static ExampleEnum1 Unset = new(0, "ExampleEnum1.Unset", "The value is not yet set.");
    
    #endregion
    
}