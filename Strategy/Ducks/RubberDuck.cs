using SimUDuck.Behaviors;
using System;

namespace SimUDuck.Ducks
{
    class RubberDuck : Duck
    {
        private RubberDuck() { }

        public RubberDuck(string name)
        {
            this.name = name;
            this.quackBehavior = new Squeak();
            this.flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a rubber duck!");
        }
    }
}
