using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Performs the specified action on each element of the specified array.
        /// </summary>
        /// <param name="action">The action to be performed on the element.</param>
        /// <exception cref="System.ArgumentNullException">Array expansion size is zero or less.</exception>
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }
    }
}