#region

using System;

#endregion

namespace Jcd.RichEnumerations.Records;

/// <summary>
/// A helper interface to enable building auto casting into the data type aware
/// <see cref="SortableRichEnum{TValue,TEnum}" />
/// types. This helps minimize boilerplate code.
/// </summary>
/// <typeparam name="TValue">The type of the value</typeparam>
public interface ISortableRichEnumValueProvider<out TValue>
   where TValue : IComparable<TValue>
{
   /// <summary>
   /// The underlying value
   /// </summary>
   TValue Value { get; }
}