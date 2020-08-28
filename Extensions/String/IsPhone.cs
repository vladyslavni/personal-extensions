using System.Text.RegularExpressions;

namespace Extension
{
    public static class IsPhoneStringExtension
    {
        //
        // Summary:
        //    Checks if a string is a phone number.
        //
        // Returns:
        //    Boolean result of the operation.
        public static bool IsPhone(this string text)
        {
            return Regex.IsMatch(text, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$"); 
        }
    }
}