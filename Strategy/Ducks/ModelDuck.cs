
using SimUDuck.Behaviors;
using System;
namespace SimUDuck.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
