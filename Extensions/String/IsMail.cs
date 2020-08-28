using System.Text.RegularExpressions;

namespace Extension
{
    public static class IsMailStringExtension
    {
        //
        // Summary:
        //    Checks if a string is mail.
        //
        // Returns:
        //    Boolean result of the operation.
        public static bool IsMail(this string text)
        {
            return Regex.IsMatch(text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); 
        }
    }
}