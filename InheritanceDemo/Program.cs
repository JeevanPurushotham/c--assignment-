using System;
using InheritanceDemo;  // Import the namespace containing the classes

namespace InheritanceDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Demonstrating Method Hiding
            Console.WriteLine("Method Hiding:");
            genericAnimal.Speak();  // Calls Animal's Speak method
            dog.Speak();            // Calls Dog's Speak method
            cat.Speak();            // Calls Cat's Speak method

            // Demonstrating Method Overriding
            Console.WriteLine("\nMethod Overriding:");
            genericAnimal.Move();   // Calls Animal's Move method
            dog.Move();             // Calls Dog's overridden Move method
            cat.Move();             // Calls Cat's overridden Move method

            // Demonstrating Method Overloading
            Console.WriteLine("\nMethod Overloading:");
            genericAnimal.Eat();            // Calls Eat() with no parameters
            genericAnimal.Eat("grass");     // Calls Eat() with a string parameter

            // Calling Move method with Animal reference to a Dog object
            Console.WriteLine("\nAnimal reference to Dog object:");
            Animal animalRefToDog = new Dog();
            animalRefToDog.Move();   // Calls Dog's overridden Move method

            Console.ReadKey();  // Wait for user to press a key
        }
    }
}
