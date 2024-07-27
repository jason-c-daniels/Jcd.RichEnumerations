#region

using System;

#endregion

namespace Jcd.RichEnumerations;

/// <summary>
/// A helper interface to enable building auto casting into the data type aware `SortableRichEnum{TValue,TEnum}`
/// types. This helps minimize boilerplate code.
/// </summary>
/// <typeparam name="TValue">The type of the value</typeparam>
public interface ISortableValueProvider<out TValue> : IValueProvider<TValue>
   where TValue : IEquatable<TValue>, IComparable<TValue>;