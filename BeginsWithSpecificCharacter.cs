// BeginsWithSpecificCharacter.cs

namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        //Create a method BeginsWithSpecificCharacter() that returns true if the string begins with the specified character, false if not.
        // The method takes a string and a character as parameters and returns a boolean value.
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
            //strings are sequences of characters.
            // To check if a string begins with a specific character, you can compare the first character of the string with the specified character.
            //First character of a string can be accessed using the index 0, so you can use str[0] to get the first character of the string.
            // If the first character of the string is equal to the specified character, then the string begins with that character and you can return true. 
            // Otherwise, you can return false.
            if (str == null)
                return false;
            return str[0] == begin;
        }
    }
}