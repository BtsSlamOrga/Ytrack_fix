// DoubleArrayForEvenInteger.cs
public class DoubleArrayForEvenInteger_Exercice
{
    public static int[] DoubleArrayForEvenInteger(int[] inputTab)
    {
        //Create a method DoubleArrayForEvenInteger() that doubles the value of each even integer in an array and returns the modified array.
        // The DoubleArrayForEvenInteger() method takes an array of integers as a parameter and
        // doubles the value of each even integer in the array. If the input array is null, you can return an empty array or handle it as you see fit.
        // inputTab is the array of integers that will be modified.
        // inputTab.Length is the number of elements in the input array. inputTab[i] is the element at index i in the input array.
        // You can use a loop to iterate through each element in the input array and check if it is an even integer. If it is, you can double its value.
        for (int i = 0; i < inputTab.Length; i++) {
            if (inputTab[i] % 2 != 0) {
                inputTab[i] *= 2;
            }
        }
        return inputTab;
    }
}