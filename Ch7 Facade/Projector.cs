using System;

namespace Ch7_Facade
{
    internal class Projector
    {
        private string model = "Top-O-Line";

        internal void On()
        {
            Console.WriteLine("{0} Projector on", model);
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("{0} Projector in widescreen mode (16x9 aspect ratio)", model);
        }

        internal void Off()
        {
            Console.WriteLine("{0} Projector off", model);
        }
    }
}