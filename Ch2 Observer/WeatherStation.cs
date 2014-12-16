using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin Weather-O-Rama Weather Station ~~~~~~~~~~~~\r\n");

            WeatherData wd = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

            wd.registerObserver(currentConditionsDisplay);
            wd.registerObserver(statisticsDisplay);
            wd.registerObserver(forecastDisplay);

            wd.setMeasurements(67.1f, 23.5f, 80f);

            Console.ReadKey();
        }
    }
}
