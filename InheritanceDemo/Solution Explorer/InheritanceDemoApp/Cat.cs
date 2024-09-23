using System;

namespace InheritanceDemo
{
    public class Cat : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Cat meows.");
        }

        public override void Move()
        {
            Console.WriteLine("Cat jumps.");
        }
    }
}
