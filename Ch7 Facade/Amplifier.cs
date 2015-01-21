using System;

namespace Ch7_Facade
{
    internal class Amplifier
    {
        private string model = "Top-O-Line";

        internal void On()
        {
            Console.WriteLine("{0} Amplifier on", model);
        }

        internal void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("{0} Amplifier setting DVD player to {1} DVD Player", model, dvd.model);
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("{0} Amplifier surround sound on (5 speakers, 1 subwoofer)", model);
        }

        internal void SetVolume(int volume)
        {
            Console.WriteLine("{0} Amplifier setting volume to {1}", model, volume);
        }

        internal void Off()
        {
            Console.WriteLine("{0} Amplifier off", model);
        }
    }
}