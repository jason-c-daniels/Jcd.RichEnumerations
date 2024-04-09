namespace Jcd.RichEnumerations.Examples.CardSelector.Menuing;

public interface IMenuProcessingResult<out T>
   where T : IMenuProcessingResult<T>
{
   static abstract T Default { get; }
   bool IsFinal { get; }
}