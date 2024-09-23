using System;

namespace AbstractClassAndDelegateDemo
{
    class Program
    {
        // Define a delegate that can point to any method with the same signature
        public delegate void DisplayDelegate(string message);

        static void Main(string[] args)
        {
            // Instantiate concrete shapes
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(10, 5);

            // Demonstrate abstract method implementation in derived classes
            circle.DisplayArea();     // Output: Circle area
            rectangle.DisplayArea();  // Output: Rectangle area

            // Using delegate to encapsulate a method
            DisplayDelegate displayMessage = DisplayMethod;
            displayMessage("This is a delegate call!");

            // Another delegate usage with a different method
            displayMessage = AnotherDisplayMethod;
            displayMessage("Delegate call with another method!");

            Console.ReadKey();
        }

        // Method to be used with delegate
        static void DisplayMethod(string message)
        {
            Console.WriteLine("DisplayMethod: " + message);
        }

        // Another method to demonstrate delegate usage
        static void AnotherDisplayMethod(string message)
        {
            Console.WriteLine("AnotherDisplayMethod: " + message);
        }
    }
}
