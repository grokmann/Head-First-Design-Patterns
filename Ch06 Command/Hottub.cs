using System;

namespace Ch6_Command
{
    public class Hottub
    {
        public Hottub()
        {
        }

        public void On()
        {
            Console.WriteLine("Hot tub is bubbling!");
        }

        public void Off()
        {
            Console.WriteLine("Hot tub is cooling to 98 degrees.");
        }
    }
}