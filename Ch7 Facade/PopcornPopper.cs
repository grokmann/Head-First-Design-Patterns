using System;

namespace Ch7_Facade
{
    internal class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popcorn Popper on");
        }

        internal void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn");
        }

        internal void Off()
        {
            Console.WriteLine("Popcorn Popper off");
        }
    }
}