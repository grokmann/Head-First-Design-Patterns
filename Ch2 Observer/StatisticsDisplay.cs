﻿using System;

namespace WeatherStation
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private ISubject weatherData;

        private StatisticsDisplay() { }

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        
        public void update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
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
    }
}
