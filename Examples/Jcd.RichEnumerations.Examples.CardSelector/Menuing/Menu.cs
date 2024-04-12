// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable VirtualMemberNeverOverridden.Global

#pragma warning disable S2743

namespace Jcd.RichEnumerations.Examples.CardSelector.Menuing;

public class Menu<TMenu, TMenuItem, TProcessingResult>
   where TMenu : Menu<TMenu, TMenuItem, TProcessingResult>
   where TMenuItem : MenuItem<TMenuItem>, IMenuItemProvider<CaseInsensitiveString, TMenuItem>
   where TProcessingResult : IEquatable<TProcessingResult>, IMenuProcessingResult<TProcessingResult>
{
   // ReSharper disable once StaticMemberInGenericType
   protected static readonly string[] EmptyStringArray = [string.Empty];
   private readonly Dictionary<TMenuItem, Func<string, TProcessingResult>> actions = new();

   protected Menu()
   {
      TMenuItem.SortItems();
   }

   public virtual void Show(string prompt = "")
   {
      Console.WriteLine();

      if (!string.IsNullOrWhiteSpace(prompt))
      {
         Console.WriteLine(prompt);
      }

      var separatorShown = false;

      // ReSharper disable once HeapView.ObjectAllocation.Possible
      foreach (var item in TMenuItem.AllItems)
      {
         if (item.Order >= 9999 && !separatorShown)
         {
            Console.WriteLine("----");
            separatorShown = true;
         }

         Console.WriteLine(item);
      }
   }

   protected virtual (TMenuItem? command, string args, string cmdText) ParseCommand(string? input)
   {
      input = input?.Trim() ?? "";
      var results = input.Split(' ', 2).Concat(EmptyStringArray).Take(2).ToArray();

      return (GetItem(results[0]), results[1], results[0]);
   }

   protected (TMenuItem selection, string args) GetSelection(string prompt = "", bool showMenu = true)
   {
      if (showMenu)
      {
         Show(prompt);
      }

      var (cmd, args, cmdText) = GetMenuSelection();

      while (cmd is null)
      {
         if (!string.IsNullOrWhiteSpace(cmdText))
         {
            Console.WriteLine("");
            Console.WriteLine($"\"{cmdText}\" is not a valid option.");

            if (showMenu)
            {
               Show(prompt);
            }
         }

         (cmd, args, cmdText) = GetMenuSelection();
      }

      return (cmd, args);
   }

   private (TMenuItem? cmd, string args, string cmdText) GetMenuSelection()
   {
      Console.Write("> ");
      var (cmd, args, cmdText) = ParseCommand(Console.ReadLine());

      return (cmd, args, cmdText);
   }

   protected virtual TMenuItem? GetItem(string key)
   {
      return TMenuItem.LookupByValue.ContainsKey(key)
                ? TMenuItem.LookupByValue[key]
                : null;
   }

   protected virtual TProcessingResult ProcessSelection(TMenuItem item, string args)
   {
      return actions.TryGetValue(item, out var result)
                ? result.Invoke(args)
                : TProcessingResult.Default;
   }

   public TMenu RegisterAction(TMenuItem item, Func<string, TProcessingResult> hook)
   {
      actions[item] = hook;

      return (TMenu) this;
   }

   public virtual TProcessingResult ProcessSelections(string prompt = "")
   {
      var init = true;

      do
      {
         var (selection, param) = GetSelection(prompt, init);
         init = false;

         var result = ProcessSelection(selection, param);

         if (result.IsFinal)
         {
            return result;
         }
      }
      while (true);
   }
}