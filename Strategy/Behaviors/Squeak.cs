using System;

namespace SimUDuck.Behaviors
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
