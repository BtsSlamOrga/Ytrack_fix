// SetPiValue.cs

namespace CSharpDiscovery.Quest01
{
    public class SetPiValue_Exercice
    {
        //Create a method SetPiValue() that sets the value of pi to 3.14159 and returns it.
        // The SetPiValue() method takes a float as a parameter and sets it to 3.14159f, then returns it.
        // f is used to indicate that the number is a float literal. If the input parameter is not used, you can ignore it or handle it as you see fit.
        // You can simply return the value of pi without using the input parameter, as the method is meant to set pi to a specific value regardless of the input.
        public static float SetPiValue(float pi)
        {
            pi = 3.14159f;
            return pi;
        }
    }
}