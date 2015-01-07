using System;

namespace WeatherStation
{
    class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private IObservable<WeatherData> weatherData;

        private StatisticsDisplay() { }

        public StatisticsDisplay(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Subscribe(this);
        }

        public void OnNext(WeatherData value)
        {
            float temperature = value.Temperature;

            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }
            display();
        }

        public void display()
        {
            Console.WriteLine("Statistics:");
            Console.WriteLine("\tAvg. temperature = " + (tempSum / numReadings));
            Console.WriteLine("\tMax. temperature: " + maxTemp);
            Console.WriteLine("\tMin. temperature: " + minTemp);
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
