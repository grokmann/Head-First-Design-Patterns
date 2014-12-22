using System;

namespace WeatherStation
{
    interface IDisplayElement
    {
        void update(float temp, float humidity, float pressure);
    }
}
