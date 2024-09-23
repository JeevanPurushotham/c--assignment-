using System;
using MyApp.Utilities;  // Import the namespace where Calculator class is defined

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling static method to add two numbers
            int sum = Calculator.Add(10, 20);
            Console.WriteLine("Static Method (Add): 10 + 20 = " + sum);

            // Calling static method to concatenate two strings
            string concatenatedString = Calculator.Concatenate("Hello", "World");
            Console.WriteLine("Static Method (Concatenate): " + concatenatedString);

            // Create an instance of the Calculator class to call instance methods
            Calculator calc = new Calculator();

            // Calling instance method to subtract two numbers
            int difference = calc.Subtract(30, 10);
            Console.WriteLine("Instance Method (Subtract): 30 - 10 = " + difference);

            // Calling instance method to multiply two floating-point numbers
            double product = calc.Multiply(4.5, 2.3);
            Console.WriteLine("Instance Method (Multiply): 4.5 * 2.3 = " + product);

            Console.ReadKey();  // Wait for user to press a key before closing
        }
    }
}
