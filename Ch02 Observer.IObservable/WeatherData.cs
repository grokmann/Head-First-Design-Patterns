namespace WeatherStation
{
    public struct WeatherData
    {
        float temperature;
        float humidity;
        float pressure;

        public WeatherData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public float Temperature
        {
            get
            {
                return temperature;
            }
        }

        public float Humidity
        {
            get
            {
                return humidity;
            }
        }

        public float Pressure
        {
            get { return pressure;
            }
        }

    }
}