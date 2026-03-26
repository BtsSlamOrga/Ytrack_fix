// Capitalize.cs

namespace CSharpDiscovery.Quest01
{
    public class Capitalize_Exercice
    {
        //Create a method Capitalize() that returns the string in uppercase.
        public static string Capitalize(string str)
        {
            //Uppercase is a type of letter case in which all letters are capitalized.
            // If the input string is null, you can return an empty string or handle it as you see fit.
            // The ToUpper() method converts all characters in a string to uppercase.
            // You can use other methods to convert a string to uppercase.
            // For exemple, you can use a algorithm to iterate through each character of the string and convert it to uppercase using the ASCII values of the characters.
            if (str == null)
                return "";
            return str.ToUpper();
        }
    }
}