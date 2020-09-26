using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///    Cuts everything except the selection.
        /// </summary>
        /// <example>
        ///   <code>{1,2,3,4,5} => Array.Slice(1,3) => {2, 3, 4}</code>
        /// </example>
        /// <param name="start">A 32-bit integer that represents the start of the selection in array.</param>
        /// <param name="end">A 32-bit integer that represents the end of the selection in array.</param>
        /// <returns>Array with clipped unselected area.</returns>
        public static T[] Slice<T>(this T[] array, int start, int end)
        {
            if (start > end) throw new ArgumentException("Incorrect slicing range. The start index is greater than the end index.");

            int size = ExtensionMath.Range(start, end);
            T[] result = new T[size];
            
            for (int i = start, j = 0; i <= end; i++, j++)
            {
                result[j] = array[i];
            }

            return result;
        }
    }
}