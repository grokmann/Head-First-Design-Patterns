using System;

namespace SimUDuck
{
    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("No way--this duck can't fly!");
        }
    }
}
