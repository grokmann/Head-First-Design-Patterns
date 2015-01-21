using System;

namespace Ch7_Facade
{
    internal class TheaterLights
    {
        internal void Dim(int percent)
        {
            Console.WriteLine("Theater Ceiling Lights dimming to {0}%", percent);
        }

        internal void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }
    }
}