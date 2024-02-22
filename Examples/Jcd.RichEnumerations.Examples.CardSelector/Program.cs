// A simple command-line "Credit Card Selector"
// You will be prompted with a menu listing four imaginary credit cards you supposedly have, by card type.
// Input the number for the card type and the system will use a rich enum to convert it to
// the internal card representation and then divulge details about the card.

using Jcd.RichEnumerations.Examples.CardSelector;

// ReSharper disable once HeapView.ObjectAllocation.Evident
var mainMenuActions = new MainMenuActionProcessor();

Console.WriteLine("Welcome to the Card Selector Example Application");
Console.WriteLine("The purpose of this app is to demonstrate quick");
Console.WriteLine("and easy conversions from user input to RichEnum");
Console.WriteLine("instances. This is demonstrated in the menu");
Console.WriteLine("processing commands");
Console.WriteLine();
Console.WriteLine();

mainMenuActions.Run();