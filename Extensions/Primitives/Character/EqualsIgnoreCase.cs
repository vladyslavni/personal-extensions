namespace Extension
{
    public static partial class CharExtension
    {
        /// <summary>
        /// Compare this character to another character ignoring case considerations.
        /// </summary>
        /// <param name="anotherCharacter">Character to compare.</param>
        /// <returns>Boolean result of the operation.</returns>
        public static bool EqualsIgnoreCase(this char input, char anotherCharacter)
        {
            return input.ToUpper().Equals(anotherCharacter.ToUpper());
        }
    }
}