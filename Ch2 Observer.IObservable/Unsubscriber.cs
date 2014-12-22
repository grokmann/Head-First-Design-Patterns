using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<IDisplayElement>> observers;
        private readonly IObserver<IDisplayElement> observer;

        public Unsubscriber(List<IObserver<IDisplayElement>> observers, IObserver<IDisplayElement> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
