#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Jcd.BitManipulation;
using Jcd.BitManipulation.Algorithms;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable StaticMemberInGenericType
// ReSharper disable UnusedAutoPropertyAccessor.Global

#pragma warning disable S2743

#endregion

namespace Jcd.RichEnumerations.Classes;

/// <summary>
/// A rich enumeration type that supports setting individual flags for up to 64 flags.
/// </summary>
/// <typeparam name="TEnum">The flag type being defined.</typeparam>
public class FlagEnum<TEnum> : RichEnumValue<ulong, TEnum>
   where TEnum : FlagEnum<TEnum>, IEquatable<TEnum>, IValueProvider<ulong>, new()
{
   #region Object overrides

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      return Name;
   }

   #endregion

   #region constructor and properties

   private static List<TEnum>? baseFlags;

   // ReSharper disable once GrammarMistakeInComment -- "a flag" is the correct grammatical construction. ReSharper is smoking something.
   /// <summary>
   /// Constructs a <see cref="FlagEnum{TEnum}" /> instance.
   /// </summary>
   /// <param name="value">The single or compound flag value</param>
   /// <param name="name">The name of the flag value</param>
   protected FlagEnum(ulong value, string name)
      : base(value)
   {
      Name = name;
      IsBaseFlag = value.IsPowerOfTwo();
   }

   /// <summary>
   /// The name of the flag instance.
   /// </summary>
   public string Name
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;

      protected init;
   }

   /// <summary>
   /// Indicates if this instance represents a value with a single bit set.
   /// </summary>
   protected bool IsBaseFlag
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;

      init;
   }

   /// <summary>
   /// Indicates if the instance was synthesized from the individual set bits.
   /// </summary>
   public bool IsSynthesized
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;

      protected init;
   }

   private static List<TEnum> BaseFlags
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get { return baseFlags ??= GetBaseFlags(); }
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static List<TEnum> GetBaseFlags()
   {
      return All.Where(x => x.IsBaseFlag).ToList();
   }

   #endregion

   #region conversion operators and helpers

   /// <summary>
   /// Determines if the passed in value can be converted into the enumerated type.
   /// </summary>
   /// <param name="value"></param>
   /// <returns></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public new static bool IsValid(ulong value)
   {
      return ByValue.ContainsKey(value) || (value & ValidFlags) == value;
   }

   /// <summary>
   /// Converts a value to a <see cref="FlagEnum{TEnum}" /> instance.
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>The <see cref="FlagEnum{TEnum}" /> instance.</returns>
   /// <exception cref="ArgumentException">When an invalid value is provided.</exception>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator FlagEnum<TEnum>(ulong value)
   {
      // verify that only defined flags are set.
      if (!IsValid(value))
      {
         throw new ArgumentException($"Cannot convert to {typeof(TEnum)}. Undefined flags in use.", nameof(value));
      }

      return ByValue.TryGetValue(value, out var result) ? result : SynthesizeResult(value);
   }

   /// <summary>
   /// Creates a new instance of the derived type.
   /// </summary>
   /// <param name="value">The value to create the result for.</param>
   /// <returns>The synthesized result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static TEnum SynthesizeResult(ulong value)
   {
      return new TEnum { Value = value, Name = SynthesizeName(value), IsBaseFlag = GetIsBaseFlag(value), IsSynthesized = true };
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static bool GetIsBaseFlag(ulong value)
   {
      return value.IsPowerOfTwo();
   }

   /// <summary>
   /// Creates the name for a synthesized instance.
   /// </summary>
   /// <param name="value">The value to create the name for.</param>
   /// <returns>The name of the synthesized instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static string SynthesizeName(ulong value)
   {
      var sb = new StringBuilder();
      sb.Append("[");
      var addComma = false;

      foreach (var item in BaseFlags)
      {
         if (item is not FlagEnum<TEnum> baseFlag || value.AreNoBitsSet(baseFlag.Value))
         {
            continue;
         }

         if (addComma)
         {
            sb.Append(", ");
         }

         sb.Append(baseFlag.Name);

         if (!addComma)
         {
            addComma = true;
         }
      }

      sb.Append("]");

      var name = sb.ToString();

      return name;
   }

   private static bool areValidFlagsSet;
   private static ulong validFlags;

   private static ulong ValidFlags
   {
      get
      {
         if (areValidFlagsSet)
         {
            return validFlags;
         }

         SetValidFlags();

         return validFlags;
      }
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static void SetValidFlags()
   {
      validFlags = All.Aggregate(0ul, (x, y) => x | y.Value);
      areValidFlagsSet = true;
   }

   #endregion

   #region Bit Manipulation Operators

   /// <summary>
   /// Perform a bitwise OR on the operands and convert to a <see cref="ulong" />
   /// </summary>
   /// <param name="left">The left hand operand.</param>
   /// <param name="right">The right hand operand.</param>
   /// <returns>The result of the OR</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong operator |(FlagEnum<TEnum> left, ulong right)
   {
      return left.Value | right;
   }

   /// <summary>
   /// Perform a bitwise OR on the operands and convert to a <see cref="ulong" />
   /// </summary>
   /// <param name="left">The left hand operand.</param>
   /// <param name="right">The right hand operand.</param>
   /// <returns>The result of the OR</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong operator |(ulong left, FlagEnum<TEnum> right)
   {
      return left | right.Value;
   }

   /// <summary>
   /// Perform a bitwise OR on the operands and convert to a <see cref="ulong" />
   /// </summary>
   /// <param name="left">The left hand operand.</param>
   /// <param name="right">The right hand operand.</param>
   /// <returns>The result of the OR</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong operator |(FlagEnum<TEnum> left, FlagEnum<TEnum> right)
   {
      return left.Value | right.Value;
   }

   #endregion
}