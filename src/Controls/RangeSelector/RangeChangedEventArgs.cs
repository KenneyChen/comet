﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comet.Controls
{
    /// <summary>
	/// Event args for a value changing event
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public class RangeChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the old value.
        /// </summary>
        public double OldValue { get; private set; }
        /// <summary>
        /// Gets the new value.
        /// </summary>
        public double NewValue { get; private set; }

        /// <summary>
        /// Gets the range property that triggered the event
        /// </summary>
        public RangeSelectorProperty ChangedRangeProperty { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueChangedEventArgs{T}"/> class.
        /// </summary>
        /// <param name="oldValue">The old value</param>
        /// <param name="newValue">The new value</param>
        /// <param name="changedRangeProperty">The changed range property</param>
        public RangeChangedEventArgs(double oldValue, double newValue, RangeSelectorProperty changedRangeProperty)
        {
            OldValue = oldValue;
            NewValue = newValue;
            ChangedRangeProperty = changedRangeProperty;
        }
    }

    /// <summary>
    /// Enumeration used to determine what value triggered ValueChanged event on the
    /// RangeSelector
    /// </summary>
    public enum RangeSelectorProperty
    {
        MinimumValue,
        MaximumValue
    }
}
