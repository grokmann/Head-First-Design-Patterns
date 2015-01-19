using System;

namespace Ch6_Command
{
    public class TV
    {
        string location;

        public TV(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} TV is on.", location);
        }

        public void Off()
        {
            Console.WriteLine("{0} TV is off.", location);
        }
    }
}