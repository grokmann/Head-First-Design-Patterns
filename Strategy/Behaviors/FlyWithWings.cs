using System;

namespace SimUDuck.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
