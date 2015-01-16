using System;

namespace Ch6_Command
{
    internal class CeilingFan
    {
        private string location;

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} fan is on.", location);
        }

        public void Off()
        {
            Console.WriteLine("{0} fan is off.", location);
        }
    }
}