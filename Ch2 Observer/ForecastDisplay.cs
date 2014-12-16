using System;

namespace WeatherStation
{
    class ForecastDisplay : IObserver
    {
        public void update(float temp, float humidity, float pressure)
        {
            display();
        }

        public void display()
        {
            Console.WriteLine("___ Forecast ___");
            Console.WriteLine("Forecast displayed...\n");
        }
    }
}
