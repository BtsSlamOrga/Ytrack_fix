// IsOdd.cs

namespace CSharpDiscovery.Quest01
{
    //Create a method IsOdd() that returns true if the number is odd, false if not.
    public class IsOdd_Exercice
    {
        public static bool IsOdd(int a)
        {
            //TODO : write your code here
            //An odd number is an integer which is not a multiple of two.
            // If it is divided by two, the result is a fraction.
            return a % 2 == 0;
        }
    }
}