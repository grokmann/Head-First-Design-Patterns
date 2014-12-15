using System;

namespace WeatherStation
{
    class ForecastDisplay
    {
        internal void update(float temp, float humidity, float pressure)
        {
            display();
        }

        public void display()
        {
            Console.WriteLine("Forecast displayed...");
        }
    }
}
