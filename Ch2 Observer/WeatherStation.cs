using System;

namespace WeatherStation
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~ Begin Weather-O-Rama Weather Station ~~~~~~~~~~~~\r\n");

            WeatherData wd = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(wd);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wd);
            ForecastDisplay forecastDisplay = new ForecastDisplay(wd);

            wd.setMeasurements(67.1f, 23.5f, 80f);
            wd.setMeasurements(82, 70, 29.2f);
            wd.setMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
