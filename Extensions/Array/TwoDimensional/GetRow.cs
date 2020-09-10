namespace Extension
{
    public static class GetRowTwoDimensionalArrayExtension
    {
        ///
        /// <summary>
        ///    Select a specific row of elements from a double array.
        /// </summary>
        /// <param name="row">A 32-bit integer that represents the index of the row.</param>
        /// <returns>A row of elements from a double array.</returns>
        public static T[] GetRow<T>(this T[,] array, int row)
        {
            int size= array.GetColumnCount();
            T[] result = new T[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = array[row, i];
            }
            
            return result;
        }
    }
}