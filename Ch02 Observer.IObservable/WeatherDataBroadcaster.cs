using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherStation
{
    class WeatherDataBroadcaster : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> observers;
        private WeatherData weatherData;
        //private IDisposable unsubscriber;

        public WeatherDataBroadcaster() {
            observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void removeObserver(IObserver<WeatherData> o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            observers.ForEach(o => o.OnNext(this.weatherData));
        }

        public void measurementsChanged()
        {
            Console.WriteLine("\n*** Measurements Changed ***");
            notifyObservers();
        }

        public void setMeasurements(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            measurementsChanged();
        }
    }
}
