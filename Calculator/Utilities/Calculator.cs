using System;

namespace MyApp.Utilities
{
    public class Calculator
    {
        // Static method to add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Instance method to subtract two integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Static method to concatenate two strings
        public static string Concatenate(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        // Instance method to multiply two floating-point numbers
        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
