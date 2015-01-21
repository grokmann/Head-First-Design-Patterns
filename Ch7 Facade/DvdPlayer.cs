using System;

namespace Ch7_Facade
{
    internal class DvdPlayer
    {
        public string model { get; private set; }
        public string movie { get; private set; }

        public DvdPlayer()
        {
            model = "Top-O-Line";
        }

        internal void On()
        {
            Console.WriteLine("{0} DVD Player on", model);
        }

        internal void Play(string movie)
        {
            this.movie = movie;
            Console.WriteLine("{0} DVD Player playing \"{1}\"", model, this.movie);
        }

        internal void Stop()
        {
            Console.WriteLine("{0} DVD Player stopped \"{1}\"", model, movie);
            movie = string.Empty;
        }

        internal void Eject()
        {
            Console.WriteLine("{0} DVD Player eject", model);
        }

        internal void Off()
        {
            Console.WriteLine("{0} DVD Player off", model);
        }
    }
}