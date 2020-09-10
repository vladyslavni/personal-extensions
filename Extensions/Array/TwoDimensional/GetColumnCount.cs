namespace Extension
{
    public static class GetColumnCountTwoDimensionalArrayExtension
    {
        ///
        /// <summary>
        ///    Finds the number of columns in a double array.
        /// </summary>
        /// <returns>Number of columns in a double array.</returns>
        public static int GetColumnCount<T>(this T[,] array)
        {
            return array.GetLength(1);
        }
    }
}