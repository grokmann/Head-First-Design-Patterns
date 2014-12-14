using System;

namespace SimUDuck.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
