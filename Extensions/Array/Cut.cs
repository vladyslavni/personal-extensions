namespace Extension
{
    public static class CutExtension
    {
        // Вырезать указанную облать в массиве
        // {1,2,3,4,5} => {1, 5}
        public static T[] Cut<T>(this T[] array, int start, int end)
        {
            int size = array.Length - ExtensionMath.Range(start, end);
            T[] result = new T[size];
            
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if ((start > i) | (i > end)) 
                {
                    result[j] = array[i];
                    j++;
                }   
            }

            return result;
        }
    }
}