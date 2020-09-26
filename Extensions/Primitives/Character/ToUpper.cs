using System;

namespace Extension
{
    public static partial class CharExtension
    {

        /// <summary>
        /// Converts the value of a Unicode character to its uppercase equivalent.
        /// </summary>
        /// <returns>Uppercase character.</returns>
        public static char ToUpper(this char с)
        {
            return Char.ToUpper(с);
        }
    }
}