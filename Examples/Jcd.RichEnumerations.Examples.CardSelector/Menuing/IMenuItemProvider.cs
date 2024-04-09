namespace Jcd.RichEnumerations.Examples.CardSelector.Menuing;

public interface IMenuItemProvider<TValue, TItem>
   where TValue : IEquatable<TValue>
{
   static abstract IReadOnlyList<TItem> AllItems { get; }
   static abstract IReadOnlyDictionary<TValue, TItem> LookupByValue { get; }
   static abstract void SortItems();
}