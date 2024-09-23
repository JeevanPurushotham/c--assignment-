using System;

namespace InheritanceDemo
{
    public class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Dog barks.");
        }

        public override void Move()
        {
            Console.WriteLine("Dog runs.");
        }
    }
}
