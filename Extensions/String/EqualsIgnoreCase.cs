using System;
using System.Collections.Generic;

namespace Extension
{
    public static partial class StringExtension
    {
        /// <summary>
        /// Compare this String to another String, ignoring case considerations.
        /// </summary>
        /// <param name="anotherString">String to compare.</param>
        /// <returns>Boolean result of the operation.</returns>
        public static bool EqualsIgnoreCase(this string input, string anotherString)
        {
            return input.ToUpper().Equals(anotherString.ToUpper());
        }
    }
}