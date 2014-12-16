using System;

namespace WeatherStation
{
    class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("___ Current Conditions ___");
            Console.WriteLine("Current conditions: {0}°F and {1}% humidity.\n", temperature, humidity);
        }
    }
}
