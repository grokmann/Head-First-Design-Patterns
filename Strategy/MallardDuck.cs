using System;

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
