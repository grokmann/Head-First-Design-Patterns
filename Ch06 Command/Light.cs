using System;

namespace Ch6_Command
{
    public class Light
    {
        string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} light is on.", location);
        }

        public void Off()
        {
            Console.WriteLine("{0} light is off.", location);
        }
    }
}