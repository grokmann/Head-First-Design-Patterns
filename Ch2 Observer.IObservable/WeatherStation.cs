using System;

namespace WeatherStation
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin Weather-O-Rama Weather Station ~~~~~~~~~~~~\r\n");

            WeatherDataBroadcaster weatherDataBroadcaster = new WeatherDataBroadcaster();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherDataBroadcaster);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherDataBroadcaster);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherDataBroadcaster);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherDataBroadcaster);

            weatherDataBroadcaster.setMeasurements(new WeatherData(67.1f, 23.5f, 80f));
            weatherDataBroadcaster.setMeasurements(new WeatherData(82, 70, 29.2f));
            weatherDataBroadcaster.setMeasurements(new WeatherData(78, 90, 29.2f));

            Console.ReadKey();
        }
    }
}
