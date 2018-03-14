using System;

namespace Ch6_Command
{
    class GarageDoor
    {
        string location;

        public GarageDoor(string location)
        {
            this.location = location;
        }

        public void Up()
        {
            Console.WriteLine("Garage door is up.");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is down.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is stopped.");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light is on.");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light is off.");
        }
    }
}
