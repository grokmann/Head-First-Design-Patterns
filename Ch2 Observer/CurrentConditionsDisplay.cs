using System;

namespace WeatherStation
{
    class CurrentConditionsDisplay
    {
        private float temperature;
        private float humidity;

        internal void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: {0}°F and {1}% humidity.", temperature, humidity);
        }
    }
}
