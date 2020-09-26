using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Increases the size of the array.
        /// </summary>
        /// <param name="size">A 32-bit integer representing the length by which array will be extended.</param>
        /// <returns>Extended array.</returns>
        /// <exception cref="System.ArgumentException">Array expansion size is zero or less.</exception>
        public static T[] Expand<T>(this T[] array, int size)
        {
            if ( 0 >= size ) throw new ArgumentException("Array expansion size is zero or less."); 

            T[] result = new T[array.Length + size];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            return result;
        }
    }
}