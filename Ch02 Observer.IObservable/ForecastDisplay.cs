using System;

namespace WeatherStation
{
    class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private IObservable<WeatherData> weatherData;

        private ForecastDisplay() { }

        public ForecastDisplay(IObservable<WeatherData> weatherDataBroadcaster)
        {
            this.weatherData = weatherDataBroadcaster;
            weatherDataBroadcaster.Subscribe(this);
        }        
        
        public void display()
        {
            Console.Write("Forecast: ");
		    if (currentPressure > lastPressure) {
			    Console.WriteLine("Improving weather on the way!");
		    } else if (currentPressure == lastPressure) {
			    Console.WriteLine("More of the same.");
		    } else if (currentPressure < lastPressure) {
			    Console.WriteLine("Watch out for cooler, rainy weather.");
		    }
        }

        public void OnNext(WeatherData value)
        {
            lastPressure = currentPressure;
            currentPressure = value.Pressure;
            display();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
