using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///    Cuts the selection out.
        /// </summary>
        /// <example>
        ///   <code>{1,2,3,4,5} => Array.Cut(1,3) => {1, 5}</code>
        /// </example>
        /// <param name="start">A 32-bit integer that represents the start of the selection in array.</param>
        /// <param name="end">A 32-bit integer that represents the end of the selection in array.</param>
        /// <returns>Array with clipped selection.</returns>
        public static T[] Cut<T>(this T[] array, int start, int end)
        {
            if (start > end) throw new ArgumentException("Incorrect cutting range. The start index is greater than the end index.");

            int size = array.Length - ExtensionMath.Range(start, end);
            T[] result = new T[size];
            
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if ((start > i) | (i > end)) 
                {
                    result[j] = array[i];
                    j++;
                }   
            }

            return result;
        }
    }
}