namespace Extension
{
    public static partial class ArrayExtension
    {
        /// <summary>
        ///     Adds values ​​to the end of the array.
        /// </summary>
        /// <param name="objects">Elements to be added to the end of the array.</param>
        /// <returns>Extended System.Array.</returns>
        public static T[] Push<T>(this T[] array, params T[] objects)
        {
            int size = array.Length + objects.Length;
            T[] result = new T[size];

            for (int i = 0, j = 0; i < size; i++)
            {
                if (array.Length > i) 
                {
                    result[i] = array[i];
                } else {
                    result[i] = objects[j];
                    j++;
                }
            }
            
            return result;
        }
    }
}