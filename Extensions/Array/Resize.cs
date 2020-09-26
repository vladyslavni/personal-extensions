using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     <para>Increases or decreases the size of the System.Array.</para>
        ///     <para>It is recommended to use "Array.Expand(int size)" if you only need to increase the size.</para>
        /// </summary>
        /// <param name="size">A 32-bit integer representing the length to be set to the array.</param>
        /// <returns>Resized array.</returns>
        /// <exception cref="System.ArgumentException">Array size cannot be zero.</exception>
        public static T[] Resize<T>(this T[] array, int size)
        {
            if (size == 0) throw new ArgumentException("Array size cannot be zero."); 
            if (size == array.Length) return array;

            T[] result = new T[size];

            if ( array.Length > size)
            {
                for (int i = 0; i < size; i++)
                {
                    result[i] = array[i];
                }

            } else if ( array.Length < size )
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[i];
                }
            }

            return result;
        }
    }
}