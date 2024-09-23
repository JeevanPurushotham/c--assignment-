using System;

namespace AbstractClassAndDelegateDemo
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method (must be overridden in derived classes)
        public abstract double CalculateArea();

        // Non-abstract method (can be used by derived classes)
        public void DisplayArea()
        {
            Console.WriteLine($"The area of the {this.GetType().Name} is {CalculateArea()}");
        }
    }

    // Concrete class for Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Override the abstract method
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;  // Area of a circle = πr²
        }
    }

    // Concrete class for Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Override the abstract method
        public override double CalculateArea()
        {
            return length * width;  // Area of a rectangle = length * width
        }
    }
}
