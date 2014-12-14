using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Duck
    {
        public virtual void quack() {
            Console.WriteLine("Quack!");
        }

        public void swim()
        {
            Console.WriteLine("Duck swims!");
        }

        public abstract void display();

        public void fly()
        {
            Console.WriteLine("Duck flies!");
        }
    }

    class MallardDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("MallardDuck displays!");
        }
    }

    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("RedheadDuck displays!");
        }
    }

    class RubberDuck : Duck
    {
        public override void quack() {
            Console.WriteLine("RubberDuck squeaks!");
        }
        
        public override void display()
        {
            Console.WriteLine("RubberDuck displays!");
        }
    }
}
