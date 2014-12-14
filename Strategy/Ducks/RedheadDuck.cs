using SimUDuck.Behaviors;
using System;

namespace SimUDuck.Ducks
{
    class RedheadDuck : Duck
    {
        private RedheadDuck() { }

        public RedheadDuck(string name)
        {
            this.name = name;
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a redhead!");
        }
    }
}
