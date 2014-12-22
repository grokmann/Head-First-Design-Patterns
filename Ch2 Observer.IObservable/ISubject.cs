namespace WeatherStation
{
    interface IHeadFirstSubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}
