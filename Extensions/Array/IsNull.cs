using System.Collections.Generic;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Checks if an array is null.
        /// </summary>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsNull<T>(this T[] obj)
        {
            return obj == null;
        }
    }
}