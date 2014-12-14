using System;

namespace SimUDuck.Behaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("This duck is flying!");
        }
    }
}
