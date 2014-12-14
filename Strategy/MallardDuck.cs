using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck() { }

        public MallardDuck(string name)
        {
            this.name = name;
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a mallard!");
        }
    }

}
