namespace Extension
{
    public static class PushExtension
    {
        // Через силу запихиваем объект в массив
        public static T[] Push<T>(this T[] array, params T[] obj)
        {
            int size = array.Length + obj.Length;
            T[] result = new T[size];

            for (int i = 0, j = 0; i < size; i++)
            {
                if (array.Length > i) 
                {
                    result[i] = array[i];
                } else {
                    result[i] = obj[j];
                    j++;
                }
            }
            
            return result;
        }
    }
}