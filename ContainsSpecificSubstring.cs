// ContainsSpecificSubstring.cs

namespace CSharpDiscovery.Quest01
{
    //Create a method ContainsSpecificSubstring() that returns true if the string contains the specified substring, false if not.
    // The method takes a string and a substring as parameters and returns a boolean value.
    public class ContainsSpecificSubstring_Exercice
    {
        // To check if a string contains a specific substring, you can use the Contains() method of the string class.
        // The Contains() method returns true if the specified substring is found within the string, and false otherwise.
        // If the input string or the pattern is null, you can return false or handle it as you see fit.
        // You can also implement your own algorithm to check if a string contains a specific substring by iterating through the string and comparing it with the pattern.
        // For example, you can use a loop to iterate through the string and check if the substring matches at each position.
        public static bool ContainsSpecificSubstring(string str, string pattern)
        {
            if (str == null || pattern == null)
                return false;
            return str.Contains(pattern);
        }
    }
}