namespace Extension
{
    public static class SliceExtension
    {
        // Отрезать всё вокруг указанной облати в массиве
        // {1,2,3,4,5} => {2, 3, 4}
        public static T[] Slice<T>(this T[] array, int start, int end)
        {
            int size = ExtensionMath.Range(start, end);
            T[] result = new T[size];
            
            for (int i = start, j = 0; i <= end; i++, j++)
            {
                result[j] = array[i];
            }

            return result;
        }
    }
}