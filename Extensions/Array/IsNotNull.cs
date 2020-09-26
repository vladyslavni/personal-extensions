using System.Collections.Generic;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Checks if an array is not null.
        /// </summary>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsNotNull<T>(this T[] obj)
        {
            return obj != null;
        }
    }
}