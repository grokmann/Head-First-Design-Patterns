﻿namespace WeatherStation
{
    interface IObserver
    {
        void update(float temperature, float humidity, float pressure);
    }
}
