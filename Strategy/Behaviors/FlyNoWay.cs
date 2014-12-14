using System;

namespace SimUDuck.Behaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("No way--this duck can't fly!");
        }
    }
}
