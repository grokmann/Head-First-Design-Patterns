using System;

namespace WeatherStation
{
    class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private IObservable<WeatherData> weatherDataBroadcaster;

        private CurrentConditionsDisplay() { }

        public CurrentConditionsDisplay(IObservable<WeatherData> weatherDataBroadcaster)
        {
            this.weatherDataBroadcaster = weatherDataBroadcaster;
            weatherDataBroadcaster.Subscribe(this);
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

        public void OnNext(WeatherData value)
        {
            this.temperature = value.Temperature;
            this.humidity = value.Humidity;
            display();       
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("An error occured: {0}", error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Completed!");
        }
    }
}
