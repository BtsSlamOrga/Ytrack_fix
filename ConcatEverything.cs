// ConcatEverything.cs

//Create a method ConcatEverything() that concatenates all the strings passed as parameters and returns the result.
namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            // The ConcatEverything() method takes a variable number of string parameters and concatenates them together.
            // *result* is the string that will hold the concatenated result.
            // If the input array of strings is null, you can return an empty string or handle it as you see fit.
            // You can use a loop to iterate through each string in the input array and concatenate them together.
            string result = "";
            if (str == null)
                return "";
            foreach (string s in str)
            {
                result += s ?? "";
            }
            return result;
        }
    }
}