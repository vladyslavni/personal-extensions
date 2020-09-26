using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Checks if array is empty.
        /// </summary>
        /// <returns>Boolean result of the operation.</returns>
        public static bool IsEmpty<T>(this T[] array)
        {
            foreach (var item in array)
            {
                if (item.IsNotNull()) return false;
            }

            return true;
        }
    }
}