namespace WeatherStation
{
    interface ISubject
    {
        void registerObserver();
        void removeObserver();
        void notifyObservers();
    }
}
