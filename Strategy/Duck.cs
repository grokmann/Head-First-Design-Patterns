using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Duck
    {
        public void quack() {
            Console.WriteLine("Quack!");
        }

        public void swim()
        {
            Console.WriteLine("Duck swims!");
        }

        public abstract void display();
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
}
