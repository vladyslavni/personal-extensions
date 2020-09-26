using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Insert elements inside an array.
        /// </summary>
        /// <param name="start">32-bit integer representing the position at which the elements will be inserted.</param>
        /// <param name="insert">Elements to be inserted into the array.</param>
        /// <returns>Extended System.Array.</returns>
        /// <exception cref="System.ArgumentException">Cannot insert elements outside the array.</exception>
        public static T[] Insert<T>(this T[] array, int start, params T[] insert)
        {
            
            if ( array.Length < start || start < 0 ) throw new ArgumentException("Cannot insert elements outside the array."); 

            int size = array.Length + insert.Length;
            T[] result = new T[size];

            for (int i = 0, j = 0; i < result.Length; i++, j++)
            {
                if(i == start)
                {
                    insert.CopyTo(result, start);
                    i += insert.Length;
                }

                result[i] = array[j];
            }

            return result;
        }
    }
}