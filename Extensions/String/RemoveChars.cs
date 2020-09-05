using System.Linq;

namespace Extension
{
    public static class RemoveCharsStringExtension
    {
        
        ///
        /// <summary>
        ///     Checks if string is a phone number.
        /// </summary>
        /// <returns>Boolean result of the operation</returns>
        public static string RemoveChars(this string input, params char[] chars)
        {
            return input.Where(c => !chars.Contains(c)).ToString();
        }
    }
}