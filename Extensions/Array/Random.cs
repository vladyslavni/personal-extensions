using System;

namespace Extension
{
    public static partial class ArrayExtension
    {
        private static Random random = new Random();

        /// <summary>
        ///     Takes a random array element and returns it.
        /// </summary>
        /// <returns>Random array element.</returns>
        public static T Random<T>(this T[] array)
        {
            int index = random.Next(array.Length);

            return array[index];
        }
    }
}