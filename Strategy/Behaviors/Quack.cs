using System;

namespace SimUDuck.Behaviors
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
