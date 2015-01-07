using System;

namespace WeatherStation
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        private CurrentConditionsDisplay() { }

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current Conditions: {0}°F and {1}% humidity.", temperature, humidity);
        }
    }
}
