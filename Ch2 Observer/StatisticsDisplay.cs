using System;

namespace WeatherStation
{
    class StatisticsDisplay
    {
        internal void update(float temperature, float humidity, float pressure)
        {
            display();
        }

        public void display()
        {
            Console.WriteLine("Statistics displayed...");
        }
    }
}
