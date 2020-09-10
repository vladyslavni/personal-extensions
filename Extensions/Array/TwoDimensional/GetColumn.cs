namespace Extension
{
    public static class GetColumnTwoDimensionalArrayExtension
    {
        ///
        /// <summary>
        ///    Select a specific column of elements from a double array.
        /// </summary>
        /// <param name="row">A 32-bit integer that represents the index of the column.</param>
        /// <returns>A column of elements from a double array.</returns>
        public static T[] GetColumn<T>(this T[,] array, int column)
        {
            int size= array.GetRowCount();
            T[] result = new T[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = array[i, column];
            }

            return result;
        }
    }
}