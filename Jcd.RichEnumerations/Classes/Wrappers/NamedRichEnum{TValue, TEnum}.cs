#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedType.Global
// ReSharper disable HeapView.PossibleBoxingAllocation
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.RichEnumerations.Classes.Wrappers;

/// <summary>
/// A <see cref="RichEnum{TValue,TEnum}" /> containing Name and Value properties.
/// </summary>
/// <param name="value">The value for the instance. This must be unique.</param>
/// <param name="name">The name for the instance. This should be unique.</param>
/// <typeparam name="TEnum">The type deriving from NdEnumeration</typeparam>
/// <typeparam name="TValue">The type of the .Value property.</typeparam>
public abstract class NamedRichEnum<TValue, TEnum>(TValue value, string name) : RichEnum<TValue, TEnum>(value)
   where TValue : IEquatable<TValue>
   where TEnum : NamedRichEnum<TValue, TEnum>, IEquatable<TEnum>
{
   /// <summary>
   /// The name for the instance. This should be unique.
   /// </summary>
   public string Name
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   } = name;

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      return $"[{Value}] {Name}";
   }
}