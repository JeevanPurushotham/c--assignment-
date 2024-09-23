using System;

namespace InheritanceDemo
{
    // Base class
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal moves.");
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Animal is eating {food}.");
        }
    }
}
