using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Checks an array for an element.
        /// </summary>
        /// <param name="element">The element to be checked for presence in the array.</param>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsContains<T>(this T[] array, T element)
        {
            if (Array.IndexOf(array, element) > -1) return true;

            return false;
        }
    }
}