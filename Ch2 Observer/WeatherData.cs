using System;

namespace WeatherStation
{
    class WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;

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

        /*
        * This method gets called
        * whenever the weather measurements
        * have been updated
        *
        */
        public void measurementsChanged()
        {
            // Your code goes here
        }
    }
}
