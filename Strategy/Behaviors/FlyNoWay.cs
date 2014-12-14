using System;

namespace SimUDuck.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
