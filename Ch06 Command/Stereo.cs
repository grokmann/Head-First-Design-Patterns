using System;

namespace Ch6_Command
{
    public class Stereo
    {
        private int volume;
        private string location;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("Stereo is on.");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off.");
        }

        public void SetCd()
        {
            Console.WriteLine("Stereo is set to CD.");
        }

        public void SetDvd()
        {
            Console.WriteLine("Stereo is set to DVD.");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo is set to radio.");
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            Console.WriteLine("Stereo is set to {0}.", volume);
        }

    }
}
