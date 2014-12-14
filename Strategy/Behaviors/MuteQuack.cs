using System;

namespace SimUDuck.Behaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence...");
        }
    }
}
