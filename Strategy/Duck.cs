using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
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

    class MallardDuck : Duck
    {
        public MallardDuck() {}

        public MallardDuck(string name)
        {
            this.name = name;
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a mallard!");
        }
    }

    class RedheadDuck : Duck
    {
        public RedheadDuck() {}

        public RedheadDuck(string name)
        {
            this.name = name;
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a redhead!");
        }
    }

    class RubberDuck : Duck
    {
        public RubberDuck() {}

        public RubberDuck(string name)
        {
            this.name = name;
        }
        
        public override void quack() {
            Console.WriteLine(name + " squeaks!");
        }
        
        public override void display()
        {
            Console.WriteLine(name + " looks like a rubber duck!");
        }
    }
}
