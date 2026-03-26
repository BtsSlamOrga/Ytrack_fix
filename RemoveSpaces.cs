// RemoveSpaces.cs

namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        //Create a method RemoveSpaces() that removes the leading and trailing spaces from a string and returns the result.
        // The RemoveSpaces() method takes a string as a parameter and removes the leading and trailing spaces from it.
        // If the input string is null, you can return an empty string or handle it as you see fit.
        // The Trim() method removes all leading and trailing white-space characters from the current string.
        // You can also implement your own algorithm to remove the leading and trailing spaces by iterating
        // through the string and checking for spaces at the beginning and end of the string.
        // For example, you can use a loop to iterate through the string and remove spaces until you find a non-space character at the beginning and end of the string.
        public static string RemoveSpaces(string str)
        {
            if (str == null)
                return "";
            return str.Trim();
        }
    }
}
