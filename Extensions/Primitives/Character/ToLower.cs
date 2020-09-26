using System;

namespace Extension
{
    public static partial class CharExtension
    {

        /// <summary>
        /// Converts the value of a Unicode character to its lowercase equivalent.
        /// </summary>
        /// <returns>Lowercase character.</returns>
        public static char ToLower(this char input)
        {
            return Char.ToLower(input);
        }
    }
}