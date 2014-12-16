using System;

namespace WeatherStation
{
    class StatisticsDisplay : IObserver
    {
        public void update(float temperature, float humidity, float pressure)
        {
            display();
        }

        public void display()
        {
            Console.WriteLine("___ Statistics ___");
            Console.WriteLine("Statistics displayed...\n");
        }
    }
}
