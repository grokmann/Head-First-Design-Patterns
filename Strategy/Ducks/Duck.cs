using SimUDuck.Behaviors;
using System;

namespace SimUDuck.Ducks
{
    abstract class Duck
    {
        public string name { get; set; }
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public virtual void performQuack() {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine(name + " swims!");
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }
    }
}
