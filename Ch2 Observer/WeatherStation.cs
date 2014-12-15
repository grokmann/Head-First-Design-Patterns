using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin Weather-O-Rama Weather Station ~~~~~~~~~~~~\r\n");

            WeatherData wd = new WeatherData();
            wd.measurementsChanged();

            Console.ReadKey();
        }
    }
}
