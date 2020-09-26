using System;
using System.Collections.Generic;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Checks an array for a string element ignoring case.
        /// </summary>
        /// <param name="element">The string element to be checked for presence in the array.</param>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsContainsIgnoreCase(this string[] array, string element)
        {
            foreach (var item in array)
            {
                if(item.EqualsIgnoreCase(element)) return true;
            }

            return false;
        }

        /// <summary>
        ///     Checks an array for a char element ignoring case.
        /// </summary>
        /// <param name="element">The char element to be checked for presence in the array.</param>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsContainsIgnoreCase(this char[] array, char element)
        {
            foreach (var item in array)
            {
                if(item.EqualsIgnoreCase(element)) return true;
            }

            return false;
        }
    }
}