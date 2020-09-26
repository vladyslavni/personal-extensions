namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///    Fills the entire array with an element
        /// </summary>
        /// <param name="value">The element with which the array will be filled.</param>
        public static void Fill<T>(this T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

    }
}