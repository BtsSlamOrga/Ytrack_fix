// GetStringSize.cs

namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        //Create a method GetStringSize() that returns the length of a string.
        // The GetStringSize() method takes a string as a parameter and returns the length of that string.
        // If the input string is null, you can return 0 or handle it as you
        public static int GetStringSize(string str)
        {
            // The length of a string is the number of characters it contains. You can use the Length property of the string class to get the length of a string.
            //.length is a property of the string class that returns the number of characters in the string. If the input string is null, you can return 0 or handle it as you see fit.
            if (str == null)
                return 0;
            return str.Length;
        }
    }
}