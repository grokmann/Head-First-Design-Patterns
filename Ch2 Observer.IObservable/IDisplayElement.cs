using System;

namespace WeatherStation
{
    interface IDisplayElement
    {
        void update(float temperature, float humidity, float pressure);
    }
}
