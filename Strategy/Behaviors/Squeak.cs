using System;

namespace SimUDuck.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
