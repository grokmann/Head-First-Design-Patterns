using System;

namespace SimUDuck
{
    abstract class Duck
    {
        public string name { get; set; }

        public virtual void quack() {
            Console.WriteLine("Quack!");
        }

        public void swim()
        {
            Console.WriteLine(name + " swims!");
        }

        public abstract void display();

        public void fly()
        {
            Console.WriteLine(name + " flies!");
        }
    }
}
