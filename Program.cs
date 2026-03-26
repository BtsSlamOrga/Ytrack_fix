// Program.cs

using System;
using CSharpDiscovery.Quest01;

// This is the main entry point of the application. It is where the program starts execution.
namespace TestCSharp
{
    class Program
    {
        // The Main method is the entry point of a C# console application.
        // It is where the program starts execution.
        // Test the HelloWorld() method from the HelloWorld_Exercice class and print the result to the console. 
        // You can also test the other methods from the other classes in the same way.
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld_Exercice.HelloWorld());
        }
    }
}