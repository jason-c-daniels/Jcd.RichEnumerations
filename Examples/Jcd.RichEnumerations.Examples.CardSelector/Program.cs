#region

using Jcd.RichEnumerations.Examples.CardSelector;

#endregion

// ReSharper disable once HeapView.ObjectAllocation.Evident
var mainMenuActions = new MainMenuActionProcessor();

Console.WriteLine("Welcome to the Card Selector Example Application");
Console.WriteLine("The purpose of this app is to demonstrate quick");
Console.WriteLine("and easy conversions from user input to RichEnum");
Console.WriteLine("instances. This is demonstrated in the menu");
Console.WriteLine("processing commands.");
Console.WriteLine();
Console.WriteLine();

mainMenuActions.Run();