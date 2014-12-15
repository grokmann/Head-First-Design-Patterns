using System;

namespace WeatherStation
{
    class WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;

        // This is all kinds of terrible.
        private CurrentConditionsDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;

        public WeatherData() {
            temperature = 67.1f;
            humidity = 23.5f;

            currentConditionsDisplay = new CurrentConditionsDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }

        public void measurementsChanged()
        {
            float temp = getTemperature();
            float humidity = getHumidity();
            float pressure = getPressure();

            // Coding to concrete implementation(!)
            currentConditionsDisplay.update(temp, humidity, pressure);
            statisticsDisplay.update(temp, humidity, pressure);
            forecastDisplay.update(temp, humidity, pressure);
        }
    }
}
