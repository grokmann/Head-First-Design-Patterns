using SimUDuck.Behaviors;
using System;

namespace SimUDuck.Ducks
{
    public abstract class Duck
    {
        public string name { get; set; }
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }
        
        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim() 
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
