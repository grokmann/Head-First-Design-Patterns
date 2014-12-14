using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Duck
    {
        public void quack() {
            Console.Write("Quack!");
        }

        public void swim()
        {
            Console.Write("Duck swims!");
        }

        public void display()
        {
            Console.WriteLine("Duck displays!");
        }
    }

    class MallardDuck : Duck
    {
        public void display()
        {
            Console.WriteLine("MallardDuck displays!");
        }
    }

    class RedheadDuck : Duck
    {
        public void display()
        {
            Console.WriteLine("RedheadDuck displays!");
        }
    }
}
