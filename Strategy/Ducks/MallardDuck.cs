using SimUDuck.Behaviors;
using System;

namespace SimUDuck.Ducks
{
    class MallardDuck : Duck
    {
        private MallardDuck() {
        }

        public MallardDuck(string name)
        {
            this.name = name;
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a mallard!");
        }
    }

}
