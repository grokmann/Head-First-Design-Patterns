using System;

namespace Ch6_Command
{
    internal class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        private string location = "";
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine("{0} fan is on high.", location);
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine("{0} fan is on medium.", location);
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine("{0} fan is on low.", location);
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine("{0} fan is off.", location);
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}