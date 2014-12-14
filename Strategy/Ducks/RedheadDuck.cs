using System;

namespace SimUDuck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck() { }

        public RedheadDuck(string name)
        {
            this.name = name;
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a redhead!");
        }
    }
}
