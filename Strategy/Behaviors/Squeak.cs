using System;

namespace SimUDuck.Behaviors
{
    class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
