using System;

namespace SimUDuck.Behaviors
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence...");
        }
    }
}
