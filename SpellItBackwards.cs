// SpellItBackwards.cs
// Create a method SpellItBackward() that takes a string as a parameter and returns the string spelled backwards.
namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        // The SpellItBackward() method takes a string as a parameter and returns the string spelled backwards. If the input string is null, you can return an empty string or handle it as you see fit.
        // You can use the ToCharArray() method to convert the string into an array of
        // characters, then use the Array.Reverse() method to reverse the order of the characters in the array, and finally create a new string from the reversed array of characters.
        // *System* is a namespace that contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.
        // Alternatively, you can implement your own algorithm to reverse the string by iterating through the string from the end to the beginning and building a new string with the characters in reverse order.
        // For example, you can use a loop to iterate through the string from the last character to the first character and concatenate each character to a new string that will hold the reversed result.
        public static string SpellItBackward(string str)
        {
            char[] chars = str.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }
    }
}