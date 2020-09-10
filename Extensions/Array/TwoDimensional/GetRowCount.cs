namespace Extension
{
    public static class GetRowCountTwoDimensionalArrayExtension
    {
        ///
        /// <summary>
        ///    Finds the number of rows in a double array.
        /// </summary>
        /// <returns>Number of rows in a double array.</returns>
        public static int GetRowCount<T>(this T[,] array)
        {
            return array.GetLength(0);
        }
    }
}