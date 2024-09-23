using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Data Types
            int integerVal = 10;
            double doubleVal = 20.5;
            char charVal = 'A';
            string stringVal = "Hello, World!";
            bool boolVal = true;

            Console.WriteLine("Built-in Data Types:");
            Console.WriteLine($"Integer: {integerVal}");
            Console.WriteLine($"Double: {doubleVal}");
            Console.WriteLine($"Character: {charVal}");
            Console.WriteLine($"String: {stringVal}");
            Console.WriteLine($"Boolean: {boolVal}");

            // 2. Nullable Types
            int? nullableInt = null;
            double? nullableDouble = 50.5;

            Console.WriteLine("\nNullable Types:");
            Console.WriteLine($"Nullable Integer: {nullableInt ?? 0} (Default to 0 if null)");
            Console.WriteLine($"Nullable Double: {nullableDouble ?? 0}");

            // 3. Arithmetic Operators
            Console.WriteLine("\nArithmetic Operations:");
            int a = 10, b = 5;
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");

            // 4. Comparison Operators
            Console.WriteLine("\nComparison Operations:");
            Console.WriteLine($"{a} == {b}: {a == b}");
            Console.WriteLine($"{a} != {b}: {a != b}");
            Console.WriteLine($"{a} > {b}: {a > b}");
            Console.WriteLine($"{a} < {b}: {a < b}");
            Console.WriteLine($"{a} >= {b}: {a >= b}");
            Console.WriteLine($"{a} <= {b}: {a <= b}");

            // 5. Logical Operators
            bool x = true, y = false;
            Console.WriteLine("\nLogical Operations:");
            Console.WriteLine($"{x} && {y}: {x && y}"); // AND
            Console.WriteLine($"{x} || {y}: {x || y}"); // OR
            Console.WriteLine($"!{x}: {!x}");           // NOT

            // 6. Null Coalescing Operator
            Console.WriteLine("\nNull Coalescing:");
            string nullString = null;
            string result = nullString ?? "Default Value"; // If nullString is null, assign default value
            Console.WriteLine($"Null Coalescing result: {result}");

            // 7. Ternary Operator
            Console.WriteLine("\nTernary Operation:");
            int ternaryResult = (a > b) ? a : b;
            Console.WriteLine($"Ternary Result (larger of {a} and {b}): {ternaryResult}");

            // 8. Increment and Decrement Operators
            Console.WriteLine("\nIncrement and Decrement:");
            int c = 5;
            Console.WriteLine($"Original value: {c}");
            Console.WriteLine($"Post-increment: {c++}");
            Console.WriteLine($"After post-increment: {c}");
            Console.WriteLine($"Pre-increment: {++c}");
            Console.WriteLine($"After pre-increment: {c}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
