using System;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck() { }

        public RubberDuck(string name)
        {
            this.name = name;
        }

        public override void quack()
        {
            Console.WriteLine(name + " squeaks!");
        }

        public override void display()
        {
            Console.WriteLine(name + " looks like a rubber duck!");
        }
    }
}
